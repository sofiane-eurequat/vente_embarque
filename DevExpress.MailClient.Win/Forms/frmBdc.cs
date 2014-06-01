using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using vente_embarque.presenter.Bdc;
using DevExpress.Utils;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmBdc : RibbonForm, IEditBdcView
    {
        private EditBdcPresenterPage editBdcPresenter;
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public OrderLine OrderLine { get; set; }
        public List<OrderLine> OrderLines =new List<OrderLine>();
        public OrderLine LigneCommande { get; set; }

        readonly ModelViewBdc sourceBdc;
        bool newBdc = true;

        public frmBdc()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
            
        public frmBdc(ModelViewBdc Bdc, bool newBdc, string caption)
        {
            InitializeComponent();
            LigneCommande = null;
            var repositoryClient = new RepositoryClient();
            var repositoryStock = new RepositoryStock();
            var repositoryOrder = new RepositoryOrder();
            editBdcPresenter = new EditBdcPresenterPage(this, repositoryClient,repositoryStock,repositoryOrder);
            editBdcPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";

            comboBoxPriorite.DataSource= Enum.GetValues(typeof(Priorite));

            GCOrderLine.DataSource = OrderLines;
            gridViewOrderLine.Columns[0].FieldName = "Name";
            //colProduct.FieldName = ProductName;

            this.newBdc = newBdc;
            DialogResult = DialogResult.Cancel;
            sourceBdc = Bdc;
        }

        private void bbiAddOrderLine_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            OrderLine ordernull = null;
            var form = new FrmEditOrderLine(Stocks,null,true);
            form.ShowDialog();
            LigneCommande = form.OrderLine;
            if (!LigneCommande.Equals(ordernull)) OrderLines.Add(LigneCommande);
            GCOrderLine.RefreshDataSource();
            Cursor.Current = Cursors.Default;
        }
        
        private void bbiSuppOrderLine_temClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmBdc_Load(object sender, EventArgs e)
        {

        }

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            editBdcPresenter.Write(comboBoxClients.SelectedItem as Client, OrderLines, (Priorite) comboBoxPriorite.SelectedItem, dateEditLivraison.DateTime, memoEditAdresssLivraion.Text);
        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {

            Close();
        }

        private void bbiEfaccer_ItemClick(object sender, ItemClickEventArgs e)
        {
            comboBoxClients.Text = "";
            comboBoxPriorite.Text = "";
            memoEditAdresssLivraion.Text = "";
            dateEditLivraison.Text = "";
        }

        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiSuppOrderLine_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show(this, TagResources.DeleteQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes)
                return;
            if (gridViewOrderLine != null) gridViewOrderLine.DeleteRow(gridViewOrderLine.FocusedRowHandle);
            GCOrderLine.RefreshDataSource();
        }
        
    }
}