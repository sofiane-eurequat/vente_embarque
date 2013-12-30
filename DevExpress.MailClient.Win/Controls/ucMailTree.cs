using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.Utils.Design;

namespace DevExpress.MailClient.Win {
    public partial class ucMailTree : BaseControl {
        public event DataSourceChangedEventHandler DataSourceChanged;
        public event MouseEventHandler ShowMenu;
        bool allowDataSourceChanged = false;
        public ucMailTree() {
            InitializeComponent();
            InitData();
            treeList1.RowHeight = Math.Max(Convert.ToInt32(treeList1.Font.GetHeight()), icFolders.ImageSize.Height) + 5;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignTimeTools.IsDesignMode)
                treeList1.FocusedNode = treeList1.Nodes[0].Nodes[0];
        }
        void InitData() {
            TreeListNode tStock = treeList1.AppendNode(new object[] { Properties.Resources.Stock, MailType.Inbox, MailFolder.Announcements, 0 }, null);
            treeList1.AppendNode(new object[] { Properties.Resources.Ajouter_Stock, MailType.Inbox, MailFolder.Announcements,1 }, tStock);
            treeList1.AppendNode(new object[] { Properties.Resources.Modifier_Stock, MailType.Sent, MailFolder.Announcements, 2 }, tStock);
            treeList1.AppendNode(new object[] { Properties.Resources.Supprimer_Stock, MailType.Deleted, MailFolder.Announcements, 3 }, tStock);



            TreeListNode tlProduit = treeList1.AppendNode(new object[] { Properties.Resources.Produit, MailType.Inbox, MailFolder.All, 4 }, null);

            treeList1.AppendNode(new object[] { Properties.Resources.Ajouter_Produit, MailType.Sent, MailFolder.All, 5 }, tlProduit);
            treeList1.AppendNode(new object[] { Properties.Resources.Modifier_Produit, MailType.Deleted, MailFolder.All, 6 }, tlProduit);
            treeList1.AppendNode(new object[] { Properties.Resources.Supprimer_produit, MailType.Draft, MailFolder.All, 7 }, tlProduit);

            TreeListNode produitNonVendue = treeList1.AppendNode(new object[] { Properties.Resources.Prouit_invendue, MailType.Inbox, MailFolder.All, 8 }, null);
            treeList1.AppendNode(new object[] { Properties.Resources.mois, MailType.Inbox, MailFolder.ASP, 9 }, produitNonVendue);
            treeList1.AppendNode(new object[] { Properties.Resources.semestre, MailType.Inbox, MailFolder.WinForms, 9 }, produitNonVendue);
            treeList1.AppendNode(new object[] { Properties.Resources.annee, MailType.Inbox, MailFolder.IDETools, 9 }, produitNonVendue);

            TreeListNode ruptureStock = treeList1.AppendNode(new object[] { Properties.Resources.Rupture_Stock, MailType.Inbox, MailFolder.All,10 }, null);

            

            treeList1.ExpandAll();
            if(!DesignTimeTools.IsDesignMode)
                CreateMessagesList(treeList1.Nodes);
            allowDataSourceChanged = true;
        }

        void CreateMessagesList(TreeListNodes nodes) {
            foreach(TreeListNode node in nodes) {
                CreateMessagesForNode(node);
                CreateMessagesList(node.Nodes);
            }
        }
        void CreateMessagesForNode(TreeListNode node) {
            List<Message> messages = new List<Message>();
            MailType mailType = (MailType)node.GetValue(colType);
            MailFolder mailFolder = (MailFolder)node.GetValue(colFolder);
            foreach(Message message in DataHelper.Messages) {
                if(message.MailType == mailType && 
                    (message.MailFolder == mailFolder || mailFolder == MailFolder.All) &&
                    !message.Deleted)
                        messages.Add(message);
            }
            node.SetValue(colData, messages);
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            Color controlColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Control");
            treeList1.Appearance.Empty.BackColor = controlColor;
            treeList1.Appearance.Row.BackColor = controlColor;
        }
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e) {
            RaiseDataSourceChanged(e.Node);
        }
        void RaiseDataSourceChanged(TreeListNode node) {
            if(DataSourceChanged != null && allowDataSourceChanged)
                DataSourceChanged(treeList1, new DataSourceChangedEventArgs(GetNodeCaption(node), node.GetValue(colData), node.GetValue(colType)));
        }
        string GetNodeCaption(TreeListNode node) { 
            string ret = string.Format("{0}", node.GetValue(colName));
            while(node.ParentNode != null) {
                node = node.ParentNode;
                ret = string.Format("{0} - {1}", node.GetValue(colName), ret);
            }
            return ret;
        }
        private void treeList1_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {

        }
        static string GetHtmlTextColor(bool focused) {
            if(focused) 
                return ColorHelper.HtmlHighlightTextColor;
            return AllowControlTextColor ? ColorHelper.HtmlControlTextColor : ColorHelper.HtmlControlTextColor2;
        }
        static bool AllowControlTextColor {
            get {
                return DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName != "Glass Oceans";
            }
        }
        int GetUnreadMessagesCount(List<Message> list) {
            return list.Count(p => p.IsUnread);
        }
        internal void RefreshTreeList() {
            treeList1.LayoutChanged();
        }
        private void treeList1_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right && ShowMenu != null) ShowMenu(sender, e); 
        }

        internal void UpdateTreeViewMessages() {
            CreateMessagesList(treeList1.Nodes);
            RefreshTreeList();
            RaiseDataSourceChanged(treeList1.FocusedNode);
        }
    }
}
