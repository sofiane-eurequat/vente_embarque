using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter;
using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win {
    public partial class frmEditStock : RibbonForm,IEditStockView
    {

        public IEnumerable<Wilaya> Wilayas { get; set; }
        private EditStockPresenterPage editStockPresenter;
        bool isMessageModified;
        bool newStock = true;
        readonly ModelViewStock sourceStock;

        public frmEditStock() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
        public frmEditStock(ModelViewStock Stock, bool newStock, string caption)
        {
            InitializeComponent();
            DictionaryHelper.InitDictionary(spellChecker1);
            var RepositoryWilaya = new RepositoryWilaya();
            editStockPresenter = new EditStockPresenterPage(this, RepositoryWilaya);
            editStockPresenter.Display();

            comboBoxWilaya.DataSource = Wilayas;


            this.newStock = newStock;
            DialogResult = DialogResult.Cancel;
            sourceStock = Stock;


          /*  var riLookUpProduct = new RepositoryItemLookUpEdit();
            GCLigneStock.RepositoryItems.Add
                (
                    GVProductLine.Columns["Name"].ColumnEdit = riLookUpProduct
                );*/

           GCLigneStock.DataSource = new List<ModelViewProductLine>()
                {
                    new ModelViewProductLine()
                        {
                            Name = "test",
                            Quantity = 20
                        }
                };


           /* riLookUpProduct.DataSource = new List<Product>()
                {
                    new Product()
                        {
                            Name = "test produit"
                        }
                };*/
            /* edtSubject.Text = Stock.Subject;
            edtTo.Text = Stock.From;
            richEditControl.HtmlText = Stock.Text;
            this.isMessageModified = newStock;
            if(string.IsNullOrEmpty(Stock.From)) 
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
            splitContainerControl1.Collapsed = newStock;*/
            //ucMessageInfo1.Init(Stock, ribbonControl.Manager);
            /*if(!newStock) {
                splitContainerControl1.Collapsed = LayoutOption.MailCollapsed;
                lblTo.Text = string.Format("{0}:", caption);
                edtTo.Properties.ReadOnly = true;
                edtSubject.Properties.ReadOnly = true;
                richEditControl.ReadOnly = true;
            }*/
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            /*if(!newStock)
                LayoutOption.MailCollapsed = splitContainerControl1.Collapsed;*/
        }
        public ModelViewStock SourceMessage { get { return sourceStock; } }

        public bool IsMessageModified {
            get { return false; /*isMessageModified || richEditControl.Modified;*/ }
            set {
                isMessageModified = value;
               // richEditControl.Modified = value;
            }
        }
        #region SaveMessage event
        EventHandler onSaveMessage;
        public event EventHandler SaveMessage { add { onSaveMessage += value; } remove { onSaveMessage -= value; } }
        protected internal virtual void RaiseSaveMessage() {
            if (onSaveMessage != null)
                onSaveMessage(this, EventArgs.Empty);
        }
        #endregion

       /* void richEditControl_SelectionChanged(object sender, EventArgs e) {
            tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable();
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected;
        }*/
        void edtTo_EditValueChanged(object sender, EventArgs e) {
            isMessageModified = true;
        }

        void edtSubject_EditValueChanged(object sender, EventArgs e) {
            isMessageModified = true;
        }
        void fileSaveItem1_ItemClick(object sender, ItemClickEventArgs e) {
            ApplyChanges();
        }
        //void frmEditMail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
        //    if (e.KeyCode == Keys.Escape) {
        //        if (QueryClose() != DialogResult.Cancel)
        //            Close();
        //    }
        //}
        void richEditControl_KeyDown(object sender, KeyEventArgs e) {
            if ((e.Modifiers & Keys.Control) != 0 && e.KeyCode == Keys.S) {
                ApplyChanges();
                e.Handled = true;
            }
        }

        void frmEditMail_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = QueryClose();
            e.Cancel = result == DialogResult.Cancel;
        }
        DialogResult QueryClose() {
            if (!IsMessageModified)
                return DialogResult.Yes;

            DialogResult result = XtraMessageBox.Show(this, Properties.Resources.SaveQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (result) {
                case DialogResult.Cancel:
                    return DialogResult.Cancel;
                case DialogResult.No:
                    return DialogResult.No;
                default:
                case DialogResult.Yes:
                    ApplyChanges();
                    return DialogResult.Yes;
            }
        }
        void ApplyChanges() {
           /* sourceStock.Date = DateTime.Now;
            sourceStock.Text = richEditControl.HtmlText;
            sourceStock.SetPlainText(ObjectHelper.GetPlainText(richEditControl.Text.TrimStart()));
            sourceStock.Subject = edtSubject.Text;
            sourceStock.From = edtTo.Text;*/

            IsMessageModified = false;

            RaiseSaveMessage();
        }


    }
}
