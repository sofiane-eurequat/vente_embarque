using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Properties;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraGrid.Columns;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter;

namespace DevExpress.MailClient.Win.Modules {
    public partial class Stock : BaseModule,IStockView {



        public IEnumerable<ModelViewStock> Stocks { get; set; }
        private StockPresenterPage _StockPresenter;
        public Stock() {
            InitializeComponent();
          


        }



        Message currentMessage;
        PopupMenu priorityMenu, dateFilterMenu;
        RibbonControl ribbon;
        FindControlManager findControlManager = null;
        FilterCriteriaManager filterCriteriaManager = null;
        Timer messageReadTimer;
        int focusedRowHandle = 0;
        bool lockUpdateCurrentMessage = true;
        public override string ModuleName { get { return Properties.Resources.MailName; } }


        

        private void Mail_Load(object sender, EventArgs e) {
          //  gridControl1.ForceInitialize();


            var repositoryStock = new RepositoryStock();
            _StockPresenter = new StockPresenterPage(this, repositoryStock);
            _StockPresenter.Display();

            gridControlStock.DataSource = Stocks;
            gridViewStock.Columns[5].Visible = false;


            var LignesProduits = Stocks.First().ProductLine;
            gridControlProduct.DataSource = LignesProduits;
            gridViewProductLine.Columns[0].Visible = false;
            gridViewProductLine.Columns[3].Visible = false;
            gridViewProductLine.Columns[1].Caption = Resources.Produit;



            GCProductDisplay.DataSource = Stocks.First().Products;
            /*LayoutViewProduct.TemplateCard.Width = 400;
            LayoutViewProduct.TemplateCard.Height = 400;*/


           // LayoutViewProduct.OptionsBehavior.AutoPopulateColumns = false;
            LayoutViewProduct.Columns["Id"].Visible = false;
            /*
            var fieldPhoto = LayoutViewProduct.Columns["Photo"].LayoutViewField;
            var filedName = LayoutViewProduct.Columns["Nom"].LayoutViewField;
            var filedCategorie = LayoutViewProduct.Columns["Categorie"].LayoutViewField;
            var filedFournisseur = LayoutViewProduct.Columns["Fournisseur"].LayoutViewField;
            var filedQuantite = LayoutViewProduct.Columns["QuantiteMin"].LayoutViewField;


            var filedRemarque = LayoutViewProduct.Columns["Remarque"].LayoutViewField;
            var fileReference = LayoutViewProduct.Columns["Reference"].LayoutViewField;

            */
            

            /*LayoutControlGroup groupInfoPrin= LayoutViewProduct.TemplateCard.AddGroup("Information Principale",
    fieldPhoto, InsertType.Top);
            groupInfoPrin.Add(fieldPhoto);
            groupInfoPrin.Add(filedName);
            groupInfoPrin.Add(filedCategorie);
            groupInfoPrin.Add(filedFournisseur);
            groupInfoPrin.Add(filedQuantite);*/
            /*
            filedName.TextSize = new Size(){Height = 12,Width = 15};
            filedName.Move(new LayoutItemDragController(filedName, fieldPhoto, InsertLocation.After, LayoutType.Horizontal));
            filedCategorie.Move(new LayoutItemDragController(filedCategorie, filedName, InsertLocation.After, LayoutType.Vertical));
            filedFournisseur.Move(new LayoutItemDragController(filedFournisseur, filedCategorie, InsertLocation.After, LayoutType.Vertical));
            filedQuantite.Move(new LayoutItemDragController(filedQuantite, filedFournisseur, InsertLocation.After, LayoutType.Vertical));

            */

            /*LayoutControlGroup groupInfoSupp = LayoutViewProduct.TemplateCard.AddGroup("Information Supplémentaire", fieldPhoto, InsertType.Bottom);

            groupInfoSupp.Add(filedRemarque);
            groupInfoSupp.Add(fileReference);*/


            var riPictureEdit = GCProductDisplay.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            if (riPictureEdit != null)
            {
                riPictureEdit.SizeMode = PictureSizeMode.Squeeze;
                LayoutViewProduct.Columns["Photo"].ColumnEdit = riPictureEdit;
                //LayoutViewProduct.Columns["Photo"]
            }
            LayoutViewProduct.Columns["Photo"].LayoutViewField.TextVisible = false;

            LayoutViewProduct.CardMinSize = new Size(350, 200);
        }
  

     
        /*protected internal override RichEditControl CurrentRichEdit { get { return ucMailViewer1.RichEdit; } }*/
        //protected override DevExpress.XtraGrid.GridControl Grid { get { return gridControl1; } }
        internal override void InitModule(DevExpress.Utils.Menu.IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            //EditorHelper.InitPriorityComboBox(repositoryItemImageComboBox1);
            this.ribbon = manager as RibbonControl;
            //ucMailViewer1.SetMenuManager(manager);
            //ShowAboutRow();
        }
       /* void ShowAboutRow() {
            Timer tmr = new Timer();
            tmr.Interval = 100;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }*/
       /* void tmr_Tick(object sender, EventArgs e) {
            lockUpdateCurrentMessage = false;
            FocusRow(0);
            ((Timer)sender).Stop();
        }*/
        void FocusRow(int rowHandle) {
            gridViewStock.FocusedRowHandle = rowHandle;
            gridViewStock.ClearSelection();
            gridViewStock.SelectRow(rowHandle);
        }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            if(firstShow) {
                filterCriteriaManager = new FilterCriteriaManager(gridViewStock);
                //filterCriteriaManager.AddBarItem(OwnerForm.ShowUnreadItem, gcIcon, "[Read] = 0");
                //filterCriteriaManager.AddBarItem(OwnerForm.ImportantItem, gcPriority, "[Priority] = 2");
                //filterCriteriaManager.AddBarItem(OwnerForm.HasAttachmentItem, gcAttachment, "[Attachment] = 1");
                filterCriteriaManager.AddClearFilterButton(OwnerForm.ClearFilterItem);
                SetPriorityMenu();
                SetDateFilterMenu();
                OwnerForm.FilterColumnManager.InitGridView(gridViewStock);
            } else {
                lockUpdateCurrentMessage = false;
                FocusRow(focusedRowHandle);
            }
          //  gridControl1.Focus();
        }
        internal override void HideModule() {
            lockUpdateCurrentMessage = true;
            focusedRowHandle = gridViewStock.FocusedRowHandle;
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            ColorHelper.UpdateColor(ilColumns, gridControlStock.LookAndFeel);
            ColorHelper.UpdateColor(ilColumns, gridControlProduct.LookAndFeel);
        }
        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            if(info == null) return;
            //info.GroupText = info.GroupText.Replace("1 items", "1 item");
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e) {
            //if(e.Column == gcRead && e.Button == MouseButtons.Left)
              //  RaiseReadMessagesChanged(e.RowHandle);
            if(e.Column.FieldName == "Priority" && e.Button == MouseButtons.Left)
                PriorityMenu.ShowPopup(gridControlStock.PointToScreen(e.Location));
            if(e.Button == MouseButtons.Right) ShowMessageMenu(gridControlStock.PointToScreen(e.Location));
            if(e.Button == MouseButtons.Left && e.Clicks == 2) 
                EditStock(e.RowHandle);
        }
        void EditStock(int rowHandle) {
            if(rowHandle < 0) return;
            Message message = gridViewStock.GetRow(rowHandle) as Message;
            //if(message != null)
              //  EditMessage(message, false, gcFrom.Caption);
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter)
                EditStock(gridViewStock.FocusedRowHandle);
        }
        void RaiseReadMessagesChanged(int rowHandle) {
            Message current = gridViewStock.GetRow(rowHandle) as Message;
            if(current == null) return;
            current.ToggleRead();
            gridViewStock.LayoutChanged();
            OwnerForm.ReadMessagesChanged();
            MakeFocusedRowVisible();
        }
        void RaiseUpdateTreeViewMessages() {
            OwnerForm.UpdateTreeViewMessages();
        }
        void RaiseEnableDelete(bool enabled) {
            OwnerForm.EnableDelete(enabled);
        }
        private void RaiseEnableMail(bool enabled) {
            OwnerForm.EnableMail(enabled, enabled && CurrentMessage != null ? CurrentMessage.IsUnread : false);
        }
        void SetPriorityMenu() {
            OwnerForm.SetPriorityMenu(PriorityMenu);
        }
        void SetDateFilterMenu() {
            OwnerForm.SetDateFilterMenu(DateFilterMenu);
        }
        void ShowMessageMenu(Point location) {
            OwnerForm.ShowMessageMenu(location);
        }
        Message CurrentMessage {
            get { return currentMessage; }
            set {
                if(currentMessage == value) return;
                currentMessage = value;
                //ucMailViewer1.ShowMessage(CurrentMessage);
                messageReadTimer.Stop();
                if(CurrentMessage != null && CurrentMessage.IsUnread)
                    messageReadTimer.Start();
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            UpdateCurrentMessage();
        }
        private void gridView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateCurrentMessage();
        }
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
            RaiseEnableDelete(EnableDelete);
        }

        void UpdateCurrentMessage() {
            if(lockUpdateCurrentMessage) return;
            if(gridViewStock.FocusedRowHandle >= 0)
                CurrentMessage = gridViewStock.GetFocusedRow() as Message;
            else {
                List<Message> rows = new List<Message>();
                GridHelper.GetChildDataRowHandles(gridViewStock, gridViewStock.FocusedRowHandle, rows);
                //ucMailViewer1.ShowMessagesInfo(rows);
                CurrentMessage = null;
                messageReadTimer.Stop();
            }
            RaiseEnableMail(gridViewStock.FocusedRowHandle >= 0);
            RaiseEnableDelete(EnableDelete);
        }
        
        protected internal override void ButtonClick(string tag) {
            switch(tag) {
                case TagResources.RotateLayout:
                    //layoutControl1.Root.RotateLayout();
                    break;
                case TagResources.FlipLayout:
                    //layoutControl1.Root.FlipLayout();
                    break;
                case TagResources.DeleteItem:
                    foreach(int row in gridViewStock.GetSelectedRows())
                        if(row >= 0) {
                            Message message = ((Message)gridViewStock.GetRow(row));
                            if(message.MailType == MailType.Deleted)
                                message.Deleted = true;
                            else
                                message.MailType = MailType.Deleted;
                        }
                    RaiseUpdateTreeViewMessages();
                    break;
                case TagResources.NewStock:
                    CreateStock();
                    break;
                case TagResources.Reply:
                    CreateReplyMailMessage();
                    break;
                case TagResources.ReplyAll:
                    CreateReplyAllMailMessages();
                    break;
                case TagResources.Forward:
                    CreateForwardMailMessage();
                    break;
                case TagResources.UnreadRead:
                    foreach(int row in gridViewStock.GetSelectedRows())
                        if(row >= 0)
                            ((Message)gridViewStock.GetRow(row)).ToggleRead();
                    gridViewStock.LayoutChanged();
                    OwnerForm.ReadMessagesChanged();
                    break;
                case TagResources.CloseSearch:
                    gridViewStock.Focus();
                    break;
                case TagResources.ResetColumnsToDefault:
                    OwnerForm.FilterColumnManager.SetDefault();
                    break;
                case TagResources.ClearFilter:
                    gridViewStock.ActiveFilter.Clear();
                    break;
                case TagResources.Preview:
                    ShowPreview();       
                    break;
            }
        }
        void ShowPreview() {
            /*if(OwnerForm != null && !OwnerForm.ShowPreview) {
                gridView1.OptionsView.ShowPreview = false;
                gridView1.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.True;
            } else {
                gridView1.OptionsView.ShowPreview = true;
                gridView1.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.False;
            }*/
        }
        bool EnableDelete {
            get {
                foreach (int row in gridViewStock.GetSelectedRows())
                    if (row >= 0)
                        return true;
                return false;
            }
        }

        void CreateStock() {
            var stock = new ModelViewStock();
            //message.MailType = MailType.Draft;
            EditStock(stock, true, null);
        }
        void EditStock(ModelViewStock stock, bool newStock, string caption)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmEditStock form = new frmEditStock(stock, newStock, caption);
            form.Load += OnEditMailFormLoad;
            form.FormClosed += OnEditMailFormClosed;
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.Show();
            Cursor.Current = Cursors.Default;
        }
        void CreateReplyAllMailMessages() {
            foreach (int row in gridViewStock.GetSelectedRows())
                CreateReplyMailMessage(row);
        }

        void CreateReplyMailMessage() {
            int[] rows = gridViewStock.GetSelectedRows();
            if (rows.Length != 1)
                return;
            CreateReplyMailMessage(rows[0]);
        }
        void CreateReplyMailMessage(int row) {
            if (row >= 0) {
                Message message = ((Message)gridViewStock.GetRow(row));
                if (message.MailType != MailType.Deleted && !message.Deleted)
                    CreateReplyMailMessage(message);
            }
        }
        void CreateReplyMailMessage(Message originalMessage) {
            Message message = new Message();
            message.MailType = MailType.Draft;
            message.From = originalMessage.From;
            message.Subject = originalMessage.Subject;
            message.Text = CreateReplyMessageText(originalMessage.Text, message.From, originalMessage.Date);
            message.IsReply = true;
            /*EditStock(message, true, null);*/
        }
        void CreateForwardMailMessage() {
            int[] rows = gridViewStock.GetSelectedRows();
            if (rows.Length != 1)
                return;
            CreateForwardMailMessage(rows[0]);
        }
        void CreateForwardMailMessage(int row) {
            if (row >= 0) {
                Message message = ((Message)gridViewStock.GetRow(row));
                if (message.MailType != MailType.Deleted && !message.Deleted)
                    CreateForwardMailMessage(message);
            }
        }
        void CreateForwardMailMessage(Message originalMessage) {
            Message message = new Message();
            message.MailType = MailType.Draft;
            message.Subject = originalMessage.Subject;
            message.Text = CreateForwardMessageText(originalMessage.Text, String.Empty);
            /*EditStock(message, true, null);*/
        }

        string CreateReplyMessageText(string text, string to, DateTime originalMessageDate) {
            using (RichEditDocumentServer server = new RichEditDocumentServer()) {
                server.HtmlText = text;
                QuoteReplyMessage(server, to, originalMessageDate);
                return server.HtmlText;
            }
        }
        string CreateForwardMessageText(string text, string to) {
            using (RichEditDocumentServer server = new RichEditDocumentServer()) {
                server.HtmlText = text;
                QuoteForwardMessage(server, to);
                return server.HtmlText;
            }
        }
        void QuoteReplyMessage(RichEditDocumentServer server, string to, DateTime originalMessageDate) {
            QuoteMessage(server);
            Document document = server.Document;
            string replyHeader = String.Format(
                Properties.Resources.ReplyText,
                to, originalMessageDate
            );
            document.InsertText(document.Range.Start, replyHeader);
        }
        void QuoteMessage(RichEditDocumentServer server) {
            Document document = server.Document;
            ParagraphCollection paragraphs = document.Paragraphs;
            foreach (Paragraph paragraph in paragraphs) {
                DocumentRange range = paragraph.Range;
                if (document.GetTableCell(range.Start) == null && !paragraph.IsInList) {
                    document.InsertText(range.Start, ">> ");
                }
            }
        }
        void QuoteForwardMessage(RichEditDocumentServer server, string to) {
            Document document = server.Document;
            string replyHeader = Properties.Resources.ForwardTextStart;
            document.InsertText(document.Range.Start, replyHeader);
            document.AppendText(Properties.Resources.ForwardTextStart);
        }
        void OnEditMailFormLoad(object sender, EventArgs e) {
            frmEditStock form = sender as frmEditStock;
            if (form != null)
                form.SaveMessage += OnEditMailFormSaveMessage;
        }

        void OnEditMailFormSaveMessage(object sender, EventArgs e) {
            frmEditStock form = sender as frmEditStock;
            if (form == null)
                return;

            /*if (!DataHelper.Messages.Contains(form.SourceMessage))
                DataHelper.Messages.Add(form.SourceMessage);*/
            RaiseUpdateTreeViewMessages();
        }

        void OnEditMailFormClosed(object sender, FormClosedEventArgs e) {
            frmEditStock form = sender as frmEditStock;
            if (form != null)
                form.SaveMessage -= OnEditMailFormSaveMessage;
        }
       /* protected internal override void MessagesDataChanged(DataSourceChangedEventArgs args) {
            partName = args.Caption;
            gridControl1.DataSource = args.List;
            if(args.Type == MailType.Deleted) {
               // gcDate.Caption = Properties.Resources.DateDeleted;
               // gcFrom.Caption = Properties.Resources.FromDeleted;
                OwnerForm.FilterColumnManager.UpdateColumnsCaption(Properties.Resources.DateDeleted, Properties.Resources.FromDeleted);
            } else if(args.Type == MailType.Inbox) {
                //gcDate.Caption = Properties.Resources.DateInbox;
                //gcFrom.Caption = Properties.Resources.FromInbox;
                OwnerForm.FilterColumnManager.UpdateColumnsCaption(Properties.Resources.DateInbox, Properties.Resources.FromInbox);
            } else {
                //gcDate.Caption = Properties.Resources.DateOutbox;
                //gcFrom.Caption = Properties.Resources.FromOutbox;
                OwnerForm.FilterColumnManager.UpdateColumnsCaption(Properties.Resources.DateOutbox, Properties.Resources.FromOutbox);
            }
            if(FindControl != null) {
                FindControl.FindEdit.Properties.NullValuePrompt = StringResources.GetSearchPrompt(args.Type);
                FindControl.FindEdit.Properties.NullValuePromptShowForEmptyValue = true;
                if(findControlManager == null)
                    findControlManager = new FindControlManager(ribbon, FindControl);
            }
            UpdateCurrentMessage();
        }*/
        FindControl FindControl {
            get {
                foreach(Control ctrl in gridControlStock.Controls) {
                    FindControl ret = ctrl as FindControl;
                    if(ret != null) return ret;
                }
                return null;
            }
        }
        PopupMenu PriorityMenu {
            get {
                if(priorityMenu == null)
                    priorityMenu = new PriorityMenu(ribbon.Manager, gridViewStock, Properties.Resources.Low16x16, Properties.Resources.High16x16);
                return priorityMenu;
            }
        }
        PopupMenu DateFilterMenu {
            get {
                if(dateFilterMenu == null)
                    dateFilterMenu = new DateFilterMenu(ribbon.Manager, gridViewStock, filterCriteriaManager);
                return dateFilterMenu;
            }
        }
        void MakeFocusedRowVisible() {
            gridViewStock.MakeRowVisible(gridViewStock.FocusedRowHandle);
        }
        protected internal override void SendKeyDown(KeyEventArgs e) {
            base.SendKeyDown(e);
            if(e.KeyData == (Keys.E | Keys.Control)) {
                if(FindControl != null) {
                    FindControl.FindEdit.Focus();
                }
            }
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            /*if(e.Column == gcSubject) {
                Message message = gridView1.GetRow(e.RowHandle) as Message;
                if(message != null)
                    e.DisplayText = message.SubjectDisplayText;
            }*/
        }
        protected override bool AllowZoomControl { get { return true; } }
        /*public override float ZoomFactor {
            get { return ucMailViewer1.ZoomFactor; }
            set { ucMailViewer1.ZoomFactor = value; }
        }*/

        private void gridView1_ColumnPositionChanged(object sender, EventArgs e) {
            CalcPreviewIndent();
        }

        void CalcPreviewIndent() {
            int indent = 0;
            foreach(GridColumn column in gridViewStock.VisibleColumns) {
                if("Priority;Read;Attachment".IndexOf(column.FieldName) > -1)
                    indent += column.Width;
                else break;
            }
            gridViewStock.PreviewIndent = indent;
        }

        
    }
}
