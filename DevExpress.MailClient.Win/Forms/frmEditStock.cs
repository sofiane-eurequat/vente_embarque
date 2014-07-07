using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Forms 
{
    public partial class frmEditStock : RibbonForm,IEditStockView
    {

        public IEnumerable<Wilaya> Wilayas { get; set; }
        private readonly EditStockPresenterPage _editStockPresenter;
        //bool isMessageModified;
        bool _newStock = true;
        readonly ModelViewStock sourceStock;

        public frmEditStock() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public frmEditStock(ModelViewStock stock, bool newStock, string caption)
        {
            InitializeComponent();
            //DictionaryHelper.InitDictionary(spellChecker1);
            var repositoryWilaya = new RepositoryWilaya();
            var repositoryStock = new RepositoryStock();
            _editStockPresenter = new EditStockPresenterPage(this, repositoryWilaya, repositoryStock);
            _editStockPresenter.Display();

            comboBoxWilaya.DataSource = Wilayas.OrderBy(c => c.Code).ToList();
            comboBoxWilaya.ValueMember = "Code";
            comboBoxWilaya.DisplayMember = "Name";
            comboBoxCommune.DataSource =
                Wilayas.First(w => w.Code == (int) comboBoxWilaya.SelectedValue).Communes.OrderBy(c => c.Name).ToList();
            comboBoxCommune.DisplayMember = "Name";
            comboBoxCommune.ValueMember = "Name";

            if (!newStock)
            {
                textEditNameStock.Text = stock.Nom;
                comboBoxWilaya.SelectedValue = stock.CodeWilaya;
                comboBoxCommune.SelectedValue = stock.Commune;
                textEditAdress.Text = stock.Adresse;
                GCLigneStock.DataSource = stock.ProductLine;
            }

            _newStock = newStock;
            DialogResult = DialogResult.Cancel;
            sourceStock = stock;
        }

        /*  var riLookUpProduct = new RepositoryItemLookUpEdit();
            GCLigneStock.RepositoryItems.Add
                (
                    GVProductLine.Columns["Name"].ColumnEdit = riLookUpProduct
                );

           GCLigneStock.DataSource = new List<ModelViewProductLine>
               {
                    new ModelViewProductLine
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
            }
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            /*if(!newStock)
                LayoutOption.MailCollapsed = splitContainerControl1.Collapsed;
        }
        public ModelViewStock SourceMessage { get { return sourceStock; } }

        public bool IsMessageModified {
            get { return false; /*isMessageModified || richEditControl.Modified; }
            set {
                isMessageModified = value;
               // richEditControl.Modified = value;
            }
        }*/
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
        }
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
            sourceStock.From = edtTo.Text;

            IsMessageModified = false;

            RaiseSaveMessage();
        }*/

        private void comboBoxWilaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxWilaya.ValueMember = "Code";
            comboBoxCommune.DataSource = Wilayas.First(w => w.Code == (int)comboBoxWilaya.SelectedValue).Communes.OrderBy(c => c.Name).ToList();

        }

        private void bbiSauvergarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editStockPresenter.Write(textEditNameStock.Text,comboBoxWilaya.SelectedItem as Wilaya,comboBoxCommune.SelectedItem as Commune, textEditAdress.Text);
        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editStockPresenter.Write(textEditNameStock.Text, comboBoxWilaya.SelectedItem as Wilaya, comboBoxCommune.SelectedItem as Commune, textEditAdress.Text);
            Close();
        }

        private void bbiEffacer_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNameStock.Text = "";
            comboBoxWilaya.Text = "";
            comboBoxCommune.Text = "";
            textEditAdress.Text = "";
        }
        
        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}
