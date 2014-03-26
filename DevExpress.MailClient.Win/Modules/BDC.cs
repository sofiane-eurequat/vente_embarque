using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using DevExpress.MailClient.Win.Controls;
using DevExpress.XtraNavBar;
using DevExpress.Utils.Text;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.MailClient.Win.Forms;
using System.Threading;
using System.ServiceModel.Web;
using System.Diagnostics;
using DevExpress.XtraRichEdit;

namespace DevExpress.MailClient.Win {
    public partial class BDC : BaseModule {
        DateTime LastFeedFetchTime = DateTime.MinValue;
        readonly TimeSpan FeedTTL = TimeSpan.FromHours(2);
        Dictionary<string, SyndicationFeed> FetchedFeeds = new Dictionary<string, SyndicationFeed>();
        bool activeViewCaption = false;
        NavBarControl mainNavBar = null;
        public override string ModuleName { get { return Properties.Resources.FeedsName; } }
        public BDC() {
            InitializeComponent();
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            SetViewCaption();
        }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            UpdateButtons();
        }
       // protected internal override RichEditControl CurrentRichEdit { get { return ucMailViewer1.RichEdit; } }
        protected override DevExpress.XtraGrid.GridControl Grid { get { return gridControl1; } }
        internal override void InitModule(DevExpress.Utils.Menu.IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            mainNavBar = data as NavBarControl;
            InitNavBar(mainNavBar);
            ucMailViewer1.SetMenuManager(manager);
        }
        private void InitNavBar(NavBarControl navBar) {
            AddNavBarItem(Properties.Resources.FeedBlogs, Properties.Resources.FeedGroupDX, "http://community.devexpress.com/blogs/MainFeed.aspx", navBar);
            AddNavBarItem(Properties.Resources.FeedVideos, Properties.Resources.FeedGroupDX, "http://tv.devexpress.com/rss.ashx", navBar);
            AddNavBarItem(Properties.Resources.FeedWebinars, Properties.Resources.FeedGroupDX, "http://www.devexpress.com/rss/webinars/", navBar);
            AddNavBarItem(Properties.Resources.FeedNews, Properties.Resources.FeedGroupDX, "http://www.devexpress.com/rss/news/news20.xml", navBar);
            AddNavBarItem(Properties.Resources.FeedBBCNews, Properties.Resources.FeedGroupMisc, "http://www.bbc.co.uk/news/rss.xml", navBar);
            AddNavBarItem(Properties.Resources.FeedEngadget, Properties.Resources.FeedGroupMisc, "http://www.engadget.com/rss.xml", navBar);
            AddNavBarItem(Properties.Resources.FeedStackOverflow, Properties.Resources.FeedGroupMisc, "http://stackoverflow.com/feeds/tag?tagnames=devexpress&sort=newest", navBar);
            navBar.LinkPressed += new NavBarLinkEventHandler(FeedNavBar_LinkPressed);
            //mainNavBar.SelectedLink = null;
            UpdateSelectedLinkData();
        }
        void FeedNavBar_LinkPressed(object sender, NavBarLinkEventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                partName = e.Link.Item.Caption;
                LoadFeedToGrid(GetFeed(e.Link.Item));
                //UpdateCurrentRecord();
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }
        void AddNavBarItem(string name, string groupName, string link, NavBarControl navBar) {
            NavBarGroup group = NavBarHelper.GetGroupByName(groupName, navBar);
            NavBarItem item = new NavBarItem(name);
            NavBarHelper.SetNavBarItemImage(item, link);
            group.ItemLinks.Add(item);
            group.Expanded = true;
            item.Tag = link;
        }
        NavBarItem CurrentItem {
            get {
                if(mainNavBar.SelectedLink == null) return null;
                return mainNavBar.SelectedLink.Item;
            }
        }
        string CurrentUrl {
            get {
                if(CurrentItem == null) return string.Empty;
                return string.Format("{0}", CurrentItem.Tag);
            }
        }
        SyndicationFeed GetCurrentFeed() {
            if(CurrentItem == null) return null;
            return GetFeed(CurrentItem);
        }
        SyndicationFeed GetFeed(NavBarItem item) {
            string key = item.Caption;
            try {
                if(!FetchedFeeds.ContainsKey(key) || DateTime.Now - LastFeedFetchTime > FeedTTL) {
                    using(XmlTextReader reader = new XmlTextReader(string.Format("{0}", item.Tag))) {
                        FeedReaderInfo info = new FeedReaderInfo(reader);
                       // Thread newThread = new Thread(new ParameterizedThreadStart(LoadFeed));
                      /*  newThread.Start(info);
                        newThread.Join(7000);
                        FetchedFeeds[key] = info.Feed;
                        newThread.Abort();*/
                    }
                    LastFeedFetchTime = DateTime.Now;
                }
                return FetchedFeeds[key];
            } catch {
                return null;
            }
        }
       /* private static void LoadFeed(object data) {
            FeedReaderInfo info = data as FeedReaderInfo;
            try {
                info.Feed = SyndicationFeed.Load(info.Reader);
            } catch {
                info.Feed = null;
            }
        }*/
        void LoadFeedToGrid(SyndicationFeed currentFeed) {
            System.Collections.IEnumerable data = SelectData(currentFeed) as System.Collections.IEnumerable;
            if(data != null) {
                gridControl1.DataSource = data.Cast<object>().ToList();
                gridView1.OptionsView.ShowViewCaption = true;
                SetViewCaption(currentFeed);
            } else {
               // ucMailViewer1.ClearInfo();
                gridView1.OptionsView.ShowViewCaption = false;
                gridControl1.DataSource = null;
                gridView1.LayoutChanged();
            }
            ShowInfo();
        }
        object SelectData(SyndicationFeed currentFeed) {
            try {
                return from i in currentFeed.Items
                       where i.Summary != null && !i.Summary.Text.Contains("<object") && !i.Summary.Text.Contains("<embed")
                       select new FeedItem() {
                           ID = i.Id,
                           Date = i.PublishDate.DateTime,
                           From = GetCreator(currentFeed, i),
                           Title = i.Title.Text.Trim(),
                           Description = i.Summary.Text.TrimStart(),
                           Url = i.Links[0].Uri.AbsoluteUri
                       };
            } catch {
                return null;
            }
        }
        string GetCreator(SyndicationFeed feed, SyndicationItem item) {
            if(item.Authors.Count > 0)
                return item.Authors[0].Name ?? item.Authors[0].Email;
            var creator = item.ElementExtensions.FirstOrDefault(e => e.OuterName == "creator");
            if(creator != null)
                return creator.GetReader().ReadInnerXml();
            return feed.Title.Text;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
           // UpdateCurrentRecord();
        }
        private void gridView1_ColumnFilterChanged(object sender, EventArgs e) {
          //  UpdateCurrentRecord();
        }
       /* void UpdateCurrentRecord() {
            FeedItem current = gridView1.GetRow(gridView1.FocusedRowHandle) as FeedItem;
            if(current != null)
                ucMailViewer1.ShowFeed(current, true);
            else ucMailViewer1.ClearInfo();
        }*/

        private void gridView1_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e) {
            if(!gridView1.OptionsView.ShowViewCaption) {
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                e.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
                StringPainter.Default.DrawString(e.Cache, e.Appearance, string.Format(Properties.Resources.FeedError, CurrentUrl), e.Bounds);
            }
        }
        private void gridView1_MouseMove(object sender, MouseEventArgs e) {
            GridHitInfo hInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
            ActiveViewCaption = hInfo.HitTest == GridHitTest.ViewCaption;
        }
        private void gridView1_MouseLeave(object sender, EventArgs e) {
            ActiveViewCaption = false;
        }
        void SetViewCaption() {
            SetViewCaption(null);
        }
        void SetViewCaption(SyndicationFeed currentFeed) {
            if(gridView1.OptionsView.ShowViewCaption) {
                string title = CurrentFeedTitle;
                if(currentFeed != null)
                    title = currentFeed.Title.Text;
                gridView1.ViewCaption = string.Format(Properties.Resources.FeedNote, title, ColorHelper.HtmlHyperLinkTextColor);
            }
        }
        string CurrentFeedTitle {
            get {
                SyndicationFeed feed = GetCurrentFeed();
                if(feed == null) return string.Empty;
                string ret = feed.Title.Text;
                if(ActiveViewCaption) ret = "<u>" + ret + "</u>";
                return ret;
            }
        }
        string CurrentFeedLink {
            get { 
                SyndicationFeed feed = GetCurrentFeed();
                if(feed == null) return string.Empty;
                return feed.Links[0].Uri.AbsoluteUri;
            }
        }
        bool ActiveViewCaption {
            get { return activeViewCaption; }
            set {
                if(activeViewCaption == value) return;
                activeViewCaption = value;
                if(activeViewCaption)
                    gridControl1.Cursor = Cursors.Hand;
                else gridControl1.Cursor = Cursors.Default;
                SetViewCaption();
            }
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e) {
            if(ActiveViewCaption)
                ObjectHelper.ShowWebSite(CurrentFeedLink);
        }
        protected internal override void ButtonClick(string tag) {
            switch(tag) {
                case TagResources.RotateLayout:
                    layoutControl1.Root.RotateLayout();
                    break;
                case TagResources.FlipLayout:
                    layoutControl1.Root.FlipLayout();
                    break;
                case TagResources.FeedDelete:
                    DeleteSelectedFeed();
                    break;
                case TagResources.FeedEdit:
                    EditCurrentFeedInfo();
                    break;
                case TagResources.FeedNew:
                    AddNewFeedInfo();
                    break;
                case TagResources.FeedRefresh:
                    if(CurrentItem != null) {
                        if(FetchedFeeds.ContainsKey(CurrentItem.Caption))
                            FetchedFeeds.Remove(CurrentItem.Caption);
                        UpdateSelectedLinkData();
                    }
                    break;
            }
        }
        void AddNewFeedInfo() {
            using(frmFeed frm = new frmFeed(DialogRole.New, mainNavBar)) {
                if(frm.ShowDialog(OwnerForm) == DialogResult.OK) {
                    if(CurrentItem == null) return;
                    FetchedFeeds.Remove(CurrentItem.Caption);
                    NavBarHelper.SetNavBarItemImage(CurrentItem, CurrentUrl);
                    UpdateSelectedLinkData();
                }
            }
        }
        void EditCurrentFeedInfo() {
            if(CurrentItem == null) return;
            frmFeed frm = new frmFeed(DialogRole.Edit, mainNavBar);
            string key = CurrentItem.Caption;
            string url = CurrentUrl;
            if(frm.ShowDialog(OwnerForm) == DialogResult.OK) {
                if(url != CurrentUrl || key != CurrentItem.Caption) 
                    FetchedFeeds.Remove(key);
                NavBarHelper.SetNavBarItemImage(CurrentItem, CurrentUrl);
                UpdateSelectedLinkData();
            }
        }
        void DeleteSelectedFeed() {
            if(CurrentItem == null) return;
            mainNavBar.Items.Remove(CurrentItem);
            UpdateSelectedLinkData();
            NavBarHelper.DeleteEmptyGroup(mainNavBar);
        }
        void UpdateSelectedLinkData() {
            if(CurrentItem == null)
                mainNavBar.SelectedLink = NavBarHelper.GetFirstItem(mainNavBar);
            if(mainNavBar.SelectedLink != null) {
                Cursor.Current = Cursors.WaitCursor;
                partName = mainNavBar.SelectedLink.Item.Caption;
                LoadFeedToGrid(GetCurrentFeed());
                Cursor.Current = Cursors.Default;
            } else
                partName = string.Empty;
            UpdateButtons();
           // UpdateCurrentRecord();
        }
        void UpdateButtons() {
            bool isFeedExist = mainNavBar.SelectedLink != null;
            if(OwnerForm != null) {
                OwnerForm.EnableEditFeed(isFeedExist);
                OwnerForm.EnableLayoutButtons(isFeedExist);
            }
            layoutControl1.Root.Visibility = isFeedExist ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        protected override bool AllowZoomControl { get { return true; } }
      /*  public override float ZoomFactor {
            get { return ucMailViewer1.ZoomFactor; }
            set { ucMailViewer1.ZoomFactor = value; }
        }*/
    }
}
