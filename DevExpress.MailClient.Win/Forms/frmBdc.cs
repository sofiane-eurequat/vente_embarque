using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private readonly EditBdcPresenterPage _editBdcPresenter;
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
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
            _editBdcPresenter = new EditBdcPresenterPage(this, repositoryClient,repositoryStock,repositoryOrder,OrderLines);
            _editBdcPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";
            comboBoxPriorite.DataSource = Enum.GetValues(typeof(Priorite));
            comboBoxEtat.DataSource = Enum.GetValues(typeof (GestionCommande));
            GCOrderLine.DataSource = OrderLines;

            /*
            if (!newBdc)
            {
                var clientName = Bdc.Client;
                comboBoxClients.DisplayMember = "Name";
                //var cl = Clients.First(c => c.Name == clientName);
                //comboBoxClients.SelectedItem = Clients.First(c=>c.Name == clientName);
                comboBoxPriorite.SelectedItem = Bdc.Priorite;
                dateEditLivraison.Text = Bdc.DateLivraison.ToShortDateString();
                memoEditAdresssLivraion.Text = Bdc.AdresseLivraison;
                //OrderLines  = Bdc.OrderLines;
                var orderline1 = new OrderLine();
                foreach (var lc in Bdc.OrderLines)
                {
                    orderline1.id = lc.Id;
                    orderline1.Product = lc.Product;
                    orderline1.Quantity = lc.Quantity;
                    OrderLines.Add(orderline1);
                }
                GCOrderLine.DataSource = OrderLines;
            }
            else
            {
                //gridViewOrderLine.Columns[0].FieldName = "Name";
                colProduct.FieldName = "Name";
                GCOrderLine.DataSource = OrderLines;
            }
            */


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

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editBdcPresenter.Write(Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client, dateEditLivraison.DateTime, memoEditAdresssLivraion.Text, (Priorite)comboBoxPriorite.SelectedItem, (GestionCommande)comboBoxEtat.SelectedItem, Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), OrderLines);
        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editBdcPresenter.Write(Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client, dateEditLivraison.DateTime, memoEditAdresssLivraion.Text, (Priorite)comboBoxPriorite.SelectedItem, (GestionCommande)comboBoxEtat.SelectedItem, Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), OrderLines);
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
            if (gridViewOrderLine == null) return;
            gridViewOrderLine.DeleteRow(gridViewOrderLine.FocusedRowHandle);
            GCOrderLine.RefreshDataSource();
        }
        
    }
}