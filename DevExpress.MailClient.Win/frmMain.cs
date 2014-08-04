using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Modules;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraRichEdit;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.Utils.About;

namespace DevExpress.MailClient.Win {
    public partial class FrmMain : RibbonForm {
        MailType _currentMailType = MailType.Inbox;
        readonly ModulesNavigator _modulesNavigator;
        internal FilterColumnsManager FilterColumnManager;
        readonly ZoomManager _zoomManager;
        readonly List<BarItem> _allowCustomizationMenuList = new List<BarItem>();

        public FrmMain() {
            InitializeComponent();
            //rpcSearch.Text = TagResources.SearchTools;
            InitNavBarGroups();
            SkinHelper.InitSkinGallery(rgbiSkins);
            RibbonButtonsInitialize();
            _modulesNavigator = new ModulesNavigator(ribbonControl1, pcMain);
            _zoomManager = new ZoomManager(ribbonControl1, _modulesNavigator, beiZoom);
            _modulesNavigator.ChangeGroup(navBarControl1.ActiveGroup, this);
            NavigationInitialize();
            SetPageLayoutStyle();
        }
        void NavigationInitialize() {
            foreach(NavBarGroup group in navBarControl1.Groups) {
                BarButtonItem item = new BarButtonItem(ribbonControl1.Manager, group.Caption);
                item.Tag = group;
                item.Glyph = group.SmallImage;
                item.ItemClick += item_ItemClick;
                bsiNavigation.ItemLinks.Add(item); 
            }
        }

        void item_ItemClick(object sender, ItemClickEventArgs e) {
            navBarControl1.ActiveGroup = (NavBarGroup)e.Item.Tag;
        }
        void RibbonButtonsInitialize() {
            InitBarButtonItem(bbiRotateLayout, TagResources.RotateLayout, Properties.Resources.RotateLayoutDescription);
            InitBarButtonItem(bbiFlipLayout, TagResources.FlipLayout, Properties.Resources.FlipLayoutDescription);
            InitBarButtonItem(bbiDeleteStock, TagResources.DeleteItem, Properties.Resources.DeleteItemDescription);
            InitBarButtonItem(bbiNewStock, TagResources.NewStock, Properties.Resources.NewItemDescription);
            InitBarButtonItem(bbiModifyStock, TagResources.ModifyStock);
            InitBarButtonItem(bbiDeleteStock, TagResources.DeleteStock, Properties.Resources.DeleteItemDescription);
            InitBarButtonItem(bbiNewProduct, TagResources.NewProduct, Properties.Resources.NewItemDescription);
            InitBarButtonItem(bbiModifyProduct, TagResources.ModifyProduct);
            InitBarButtonItem(bbiDeleteProduct, TagResources.DeleteProduct, Properties.Resources.DeleteItemDescription);
            InitBarButtonItem(bbiRefreshProduct, TagResources.Refresh);
            InitBarButtonItem(bbiCloseProduct, TagResources.Close);
            InitBarButtonItem(bbiNewProductLine, TagResources.NewProductLine, Properties.Resources.NewItemDescription);
            InitBarButtonItem(bbiModifyProductLine, TagResources.ModifyProductLine);
            InitBarButtonItem(bbiDeleteProductLine, TagResources.DeleteProductLine, Properties.Resources.DeleteItemDescription);
            InitBarButtonItem(bbiUnreadRead, TagResources.UnreadRead, Properties.Resources.UnreadReadDescription);
            InitBarButtonItem(bbiCloseSearch, TagResources.CloseSearch, Properties.Resources.CloseSearchDescription);
            InitBarButtonItem(bbiSubjectColumn, TagResources.SubjectColumn);
            InitBarButtonItem(bbiFromColumn, TagResources.PersonColumn);
            InitBarButtonItem(bbiDateColumn, TagResources.DateColumn);
            InitBarButtonItem(bbiPriorityColumn, TagResources.PriorityColumn);
            InitBarButtonItem(bbiAttachmentColumn, TagResources.AttachmentColumn);
            InitBarButtonItem(bbiResetColumnsToDefault, TagResources.ResetColumnsToDefault);
            InitBarButtonItem(bbiDate, TagResources.DateFilterMenu);
            InitBarButtonItem(bbiClearFilter, TagResources.ClearFilter);
            InitBarButtonItem(bbiNewFeed, TagResources.FeedNew, Properties.Resources.NewFeedDescription);
            InitBarButtonItem(bbiEditFeed, TagResources.FeedEdit, Properties.Resources.EditFeedDescription);
            InitBarButtonItem(bbiDeleteFeed, TagResources.FeedDelete, Properties.Resources.DeleteFeedDescription);
            InitBarButtonItem(bbiRefreshFeed, TagResources.FeedRefresh, Properties.Resources.RefreshFeedDescription);
            InitBarButtonItem(bbiNewContact, TagResources.ContactNew, Properties.Resources.NewContactDescription);
            InitBarButtonItem(bbiEditContact, TagResources.ContactEdit, Properties.Resources.EditContactDescription);
            InitBarButtonItem(bbiDeleteContact, TagResources.ContactDelete, Properties.Resources.DeleteContactDescription);
            InitBarButtonItem(bbiNewTask, TagResources.TaskNew, Properties.Resources.NewTaskDescription);
            InitBarButtonItem(bbiEditTask, TagResources.TaskEdit, Properties.Resources.EditTaskDescription);
            InitBarButtonItem(bbiDeleteTask, TagResources.TaskDelete, Properties.Resources.DeleteTaskDescription);
            InitBarButtonItem(bbiTodayFlag, FlagStatus.Today, Properties.Resources.FlagTodayDescription);
            InitBarButtonItem(bbiTomorrowFlag, FlagStatus.Tomorrow, Properties.Resources.FlagTomorrowDescription);
            InitBarButtonItem(bbiThisWeekFlag, FlagStatus.ThisWeek, Properties.Resources.FlagThisWeekDescription);
            InitBarButtonItem(bbiNextWeekFlag, FlagStatus.NextWeek, Properties.Resources.FlagNextWeekDescription);
            InitBarButtonItem(bbiNoDateFlag, FlagStatus.NoDate, Properties.Resources.FlagNoDatekDescription);
            InitBarButtonItem(bbiCustomFlag, FlagStatus.Custom, Properties.Resources.FlagCustomDescription);
            //InitBarButtonItem(bbiShowPreview, TagResources.Preview, Properties.Resources.ShowPreviewDescription);
            InitBarButtonItem(bbiNewSecteur, TagResources.NewSecteur);
            InitBarButtonItem(bbiModifySecteur, TagResources.ModifySecteur);
            InitBarButtonItem(bbiDeleteSecteur, TagResources.DeleteSecteur, Properties.Resources.DeleteItemDescription);
            InitBarButtonItem(bbiNewBdc, TagResources.NewBdc);
            InitBarButtonItem(bbiModifyBdc, TagResources.ModifyBdc);
            InitBarButtonItem(bbiDeleteBdc, TagResources.DeleteBdc);
            InitBarButtonItem(bbiRefreshBdc, TagResources.Refresh);
            InitBarButtonItem(bbiCloseBdc, TagResources.Close);
            InitBarButtonItem(bbiModifyOrderLine, TagResources.ModifyOrderLine);
            InitBarButtonItem(bbiDeleteOrderLine, TagResources.DeleteOrderLine);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[0], TagResources.ContactList, Properties.Resources.ContactListDescription);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[1], TagResources.ContactAlphabetical, Properties.Resources.ContactAlphabeticalDescription);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[2], TagResources.ContactByState, Properties.Resources.ContactByStateDescription);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[3], TagResources.ContactCard, Properties.Resources.ContactCardDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[0], TagResources.TaskList, Properties.Resources.TaskListDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[1], TagResources.TaskToDoList, Properties.Resources.TaskToDoListDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[2], TagResources.TaskCompleted, Properties.Resources.TaskCompletedDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[3], TagResources.TaskToday, Properties.Resources.TaskTodayDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[4], TagResources.TaskPrioritized, Properties.Resources.TaskPrioritizedDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[5], TagResources.TaskOverdue, Properties.Resources.TaskOverdueDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[6], TagResources.TaskSimpleList, Properties.Resources.TaskSimpleListDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[7], TagResources.TaskDeferred, Properties.Resources.TaskDeferredDescription);
            bvbiSaveAs.Tag = TagResources.MenuSaveAs;
            bvbiSaveAttachment.Tag = TagResources.MenuSaveAttachment;
            bvbiSaveCalendar.Tag = TagResources.MenuSaveCalendar;
            bbiPriority.Hint = Properties.Resources.PriorityDescription;
            bsiNavigation.Hint = Properties.Resources.NavigationDescription;
            bbiShowUnread.Hint = Properties.Resources.SearchUnreadDescription;
            bbiDate.Hint = Properties.Resources.SearchReceivedDescription;
            bbiImportant.Hint = Properties.Resources.SearchImportantDescription;
            bbiHasAttachment.Hint = Properties.Resources.SearchHasAttachmentDescription;
            bbiClearFilter.Hint = Properties.Resources.SearchClearDescription;
            bsiColumns.Hint = Properties.Resources.SearchColumnsDescription;
            bbiResetColumnsToDefault.Hint = Properties.Resources.SearchResetDescription;
            bbiCloseSearch.Hint = Properties.Resources.SearchCloseDescription;

            var items = new List<BarButtonItem>
                {
                    bbiSubjectColumn,
                    bbiFromColumn,
                    bbiDateColumn,
                    bbiPriorityColumn,
                    bbiAttachmentColumn,
                    bbiDate
                };
            FilterColumnManager = new FilterColumnsManager(items);
            ucContacts1.SynchronizeGalleryItems(rgbiCurrentView);
            ucCalendar1.SetBarController(schedulerBarController1);
            _allowCustomizationMenuList.Add(bbiFlipLayout); 
            _allowCustomizationMenuList.Add(bbiRotateLayout);
            _allowCustomizationMenuList.Add(bsiNavigation);
            _allowCustomizationMenuList.Add(rgbiSkins);
            ribbonControl1.Toolbar.ItemLinks.Add(rgbiSkins);
        }

        void InitGalleryItem(GalleryItem galleryItem, string tag, string description) {
            galleryItem.Tag = tag;
            galleryItem.Hint = description;
        }
        //internal bool ShowPreview { get { return bbiShowPreview.Down; } }
        internal ZoomManager ZoomManager { get { return _zoomManager; } }
        internal BarButtonItem ShowUnreadItem { get { return bbiShowUnread; } }
        internal BarButtonItem ImportantItem { get { return bbiImportant; } }
        internal BarButtonItem HasAttachmentItem { get { return bbiHasAttachment; } }
        internal BarButtonItem ClearFilterItem { get { return bbiClearFilter; } }
        internal BackstageViewButtonItem SaveAsMenuItem { get { return bvbiSaveAs; } }
        internal BackstageViewButtonItem SaveAttachmentMenuItem { get { return bvbiSaveAttachment; } }
        internal BackstageViewButtonItem SaveCalendar { get { return bvbiSaveCalendar; } }
        internal InRibbonGallery TaskGallery { get { return rgbiCurrentViewTasks.Gallery; } }
        internal PopupMenu FlagStatusMenu { get { return pmFlagStatus; } }
        void InitBarButtonItem(BarButtonItem buttonItem, object tag) {
            InitBarButtonItem(buttonItem, tag, string.Empty);
        }
        void InitBarButtonItem(BarButtonItem buttonItem, object tag, string description) {
            //TODO: ici on gere l'evenement du click sur un des items de la barre
            buttonItem.ItemClick += bbi_ItemClick;
            buttonItem.Hint = description;
            buttonItem.Tag = tag;
        }
        void InitNavBarGroups() {
            nbgMail.Tag = new NavBarGroupTagObject("Stock", typeof(Stock));
            nbgCalendar.Tag = new NavBarGroupTagObject("Calendar", typeof(Calendar));
            nbgContacts.Tag = new NavBarGroupTagObject("Contacts", typeof(Contacts));
            nbgSecteur.Tag = new NavBarGroupTagObject("Secteur", typeof (Sector));
            nbgBdc.Tag = new NavBarGroupTagObject("BDC", typeof(Bdc2));
            nbgProduct.Tag = new NavBarGroupTagObject("Produit", typeof (Product));
            //nbgTasks.Tag = new NavBarGroupTagObject("Tasks", typeof(DevExpress.MailClient.Win.Tasks));
        }
        public void ReadMessagesChanged() {
           // ucMailTree1.RefreshTreeList();
        }
        public void UpdateTreeViewMessages() {
           // ucMailTree1.UpdateTreeViewMessages();
        }
        internal void EnableDelete(bool enabled) {
            bbiDeleteStock.Enabled = enabled;
            bbiUnreadRead.Enabled = enabled;
            bbiPriority.Enabled = enabled;
        }
        internal void EnableMail(bool enabled, bool unread) {
            bbiNewProduct.Enabled = enabled && _currentMailType == MailType.Inbox;
            bbiModifyProduct.Enabled = enabled && _currentMailType == MailType.Inbox;
            bbiDeleteProduct.Enabled = enabled && _currentMailType == MailType.Inbox;
        }
        internal void EnableEditFeed(bool enabled) {
            bbiDeleteFeed.Enabled = enabled;
            bbiEditFeed.Enabled = enabled;
            bbiRefreshFeed.Enabled = enabled;
        }
        internal void EnableEditContact(bool enabled) {
            bbiDeleteContact.Enabled = enabled;
            bbiEditContact.Enabled = enabled;
        }
        internal void EnableLayoutButtons(bool enabled) {
            bbiRotateLayout.Enabled = enabled;
            bbiFlipLayout.Enabled = enabled;
        }
        internal void EnabledFlagButtons(bool enabled, FlagStatus status) {
            List<BarButtonItem> list = new List<BarButtonItem> { bbiTodayFlag, bbiTomorrowFlag, bbiThisWeekFlag, 
                bbiNextWeekFlag, bbiNoDateFlag, bbiCustomFlag };
            foreach(BarButtonItem item in list) {
                item.Enabled = enabled;
                item.Down = status.Equals(item.Tag);
            }
            bbiDeleteTask.Enabled = enabled;
            bbiEditTask.Enabled = enabled;
        }
        internal void EnableZoomControl(bool enabled) {
            beiZoom.Enabled = enabled;
        }
        internal void SetPriorityMenu(PopupMenu menu) {
            bbiPriority.DropDownControl = menu;
        }
        internal void SetDateFilterMenu(PopupMenu menu) {
            bbiDate.DropDownControl = menu;
        }
        internal void ShowMessageMenu(Point location) {
            pmMessage.ShowPopup(location);
        }
        internal void ShowInfo(int? count) {
            if(count == null) bsiInfo.Caption = string.Empty;
            else
                bsiInfo.Caption = string.Format(Properties.Resources.InfoText, count.Value);
            HtmlText = string.Format("{0}{1}", GetModuleName(), GetModulePartName());
        }
        string GetModuleName() {
            if(string.IsNullOrEmpty(_modulesNavigator.CurrentModule.PartName)) return CurrentModuleName;
            return string.Format("<b>{0}</b>", CurrentModuleName);
        }
        string GetModulePartName() {
            if(string.IsNullOrEmpty(_modulesNavigator.CurrentModule.PartName)) return null;
            return string.Format(" - {0}", _modulesNavigator.CurrentModule.PartName);
        }
        private void navBarControl1_ActiveGroupChanged(object sender, NavBarGroupEventArgs e) {
            object data = GetModuleData((NavBarGroupTagObject)e.Group.Tag);
            _modulesNavigator.ChangeGroup(e.Group, data);
        }
        private void bbi_ItemClick(object sender, ItemClickEventArgs e) {
            _modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }
        private void ucMailTree1_DataSourceChanged(object sender, DataSourceChangedEventArgs e) {
            _currentMailType = e.Type;
            _modulesNavigator.CurrentModule.MessagesDataChanged(e);
            ShowInfo(e.List.Count);
        }
        private void ucMailTree1_ShowMenu(object sender, MouseEventArgs e) {
            //pmTreeView.ShowPopup(ucMailTree1.PointToScreen(e.Location));
        }
        private void pmTreeView_BeforePopup(object sender, CancelEventArgs e) {
            bciShowAllMessageCount.Checked = DataHelper.ShowAllMessageCount;
            bciShowUnreadMessageCount.Checked = DataHelper.ShowUnreadMessageCount;
        }
        private void bciShowAllMessageCount_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DataHelper.ShowAllMessageCount = bciShowAllMessageCount.Checked;
            //ucMailTree1.RefreshTreeList();
        }
        private void bciShowUnreadMessageCount_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DataHelper.ShowUnreadMessageCount = bciShowUnreadMessageCount.Checked;
            //ucMailTree1.RefreshTreeList();
        }
        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            _modulesNavigator.CurrentModule.SendKeyDown(e);   
        }
        protected object GetModuleData(NavBarGroupTagObject tag) {
            if(tag == null) return null;
            if (tag.ModuleType == typeof(Calendar)) return ucCalendar1;
            //if(tag.ModuleType == typeof(DevExpress.MailClient.Win.Feeds)) return navBarControl2;
           // if(tag.ModuleType == typeof(DevExpress.MailClient.Win.Tasks)) return nbgTasks;
            return null;
        }
        private void navBarControl1_NavPaneStateChanged(object sender, EventArgs e) {
            ucCalendar1.StateChanged(navBarControl1.OptionsNavPane.ActualNavPaneState);
            SetPageLayoutStyle();
        }
        private void ucContacts1_CheckedChanged(object sender, EventArgs e) {
            _modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", ((CheckEdit)sender).Tag));
        }

        private void bvbiExit_ItemClick(object sender, BackstageViewItemEventArgs e) {
            this.Close();
        }

        private void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e) {
            if(TagResources.OpenCalendar.Equals(e.Item.Tag)) {
                ribbonControl1.HideApplicationButtonContentControl();
                this.Refresh();
                navBarControl1.ActiveGroup = nbgCalendar;
            }
            _modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }

        private void backstageViewControl1_ItemClick(object sender, BackstageViewItemEventArgs e) {
            if(_modulesNavigator.CurrentModule == null) return;
            _modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }
        void SetPageLayoutStyle() {
            bbiNormal.Down = navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Expanded;
            bbiReading.Down = navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed;
        }

        private void bbiNormal_ItemClick(object sender, ItemClickEventArgs e) {
            if(bbiNormal.Down) navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded;
            else 
                bbiNormal.Down = true;
        }

        private void bbiReading_ItemClick(object sender, ItemClickEventArgs e) {
            if(bbiReading.Down) navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed;
            else 
                bbiReading.Down = true;
        }

        private void rgbiCurrentView_GalleryInitDropDownGallery(object sender, InplaceGalleryEventArgs e) {
            e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiManageView);
            e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiSaveCurrentView);
            e.PopupGallery.SynchWithInRibbonGallery = true;
        }
        
        private void rgbiCurrentViewTasks_GalleryItemClick(object sender, GalleryItemClickEventArgs e) {
            _modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }

        private void ucCalendar1_VisibleChanged(object sender, EventArgs e) {
            if(ucCalendar1.Visible)
                ucCalendar1.UpdateTreeListHeight();
        }
        
        private void bvtiPrint_SelectedChanged(object sender, BackstageViewItemEventArgs e) {
            if(backstageViewControl1.SelectedTab == bvtiPrint)
                this.printControl1.InitPrintingSystem();
        }
        private void ribbonControl1_BeforeApplicationButtonContentControlShow(object sender, EventArgs e) {
            if(backstageViewControl1.SelectedTab == bvtiPrint) backstageViewControl1.SelectedTab = bvtiInfo;
            bvtiPrint.Enabled = CurrentRichEdit != null || CurrentPrintableComponent != null;
            bvtiExport.Enabled = CurrentExportComponent != null;
        }
        public IPrintable CurrentPrintableComponent { get { return _modulesNavigator.CurrentModule.PrintableComponent; } }
        public IPrintable CurrentExportComponent { get { return _modulesNavigator.CurrentModule.ExportComponent; } }
        public RichEditControl CurrentRichEdit { get { return _modulesNavigator.CurrentModule.CurrentRichEdit; } }
        public string CurrentModuleName { get { return _modulesNavigator.CurrentModule.ModuleName; } }

        private void ribbonControl1_ShowCustomizationMenu(object sender, RibbonCustomizationMenuEventArgs e) {
            e.CustomizationMenu.InitializeMenu();
            if(e.Link == null || !_allowCustomizationMenuList.Contains(e.Link.Item))
                e.CustomizationMenu.RemoveLink(e.CustomizationMenu.ItemLinks[0]);
        }

        
    }
}
