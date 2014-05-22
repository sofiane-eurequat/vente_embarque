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
        public OrderLine orderLineTest =null;

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
            var repositoryClient = new RepositoryClient();
            var repositoryStock = new RepositoryStock();
            editBdcPresenter = new EditBdcPresenterPage(this, repositoryClient,repositoryStock);
            editBdcPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";

            comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            comboBoxStock.DisplayMember = "Name";

            comboBoxPriorite.DataSource= Enum.GetValues(typeof(Priorite));

            GCOrderLine.DataSource = OrderLines;
            //colProduct.FieldName = ProductName;

            this.newBdc = newBdc;
            DialogResult = DialogResult.Cancel;
            sourceBdc = Bdc;
        }

        private void bbiAddOrderLine_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new FrmEditOrderLine(Stocks,null,true);
            form.ShowDialog();
            var ligneCommande = form.OrderLine;
            if (!ligneCommande.Equals(orderLineTest)) OrderLines.Add(ligneCommande);
            GCOrderLine.RefreshDataSource();
            Cursor.Current = Cursors.Default;
        }
        
        private void bbiSuppOrderLine_ItemClick(object sender, ItemClickEventArgs e)
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
            editBdcPresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxClients.SelectedItem as Client, (Priorite) comboBoxPriorite.SelectedItem);
        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {

            Close();
        }

        private void bbiEfaccer_ItemClick(object sender, ItemClickEventArgs e)
        {
            comboBoxStock.Text = "";
            comboBoxClients.Text = "";
            comboBoxPriorite.Text = "";
            memoEditAdresssLivraion.Text = "";
            dateEditLivraison.Text = "";
        }

        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        
    }
}