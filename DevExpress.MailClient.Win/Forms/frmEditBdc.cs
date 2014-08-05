using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class FrmEditBdc : RibbonForm, IEditBdcView
    {
        private readonly EditBdcPresenterPage _editBdcPresenter;
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public List<OrderLine> OrderLines = new List<OrderLine>();
        public List<OrderLine> orderLines = new List<OrderLine>();
        public OrderLine LigneCommande { get; set; }
        public bool IsBdcModified;
        public Guid IdOrder { get; set; }

        readonly ModelViewBdc _sourceBdc;
        readonly bool _newBdc = true;

        public FrmEditBdc()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        internal FrmEditBdc(ModelViewBdc bdc, bool newBdc, string caption)
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
            comboBoxClients.ValueMember = "Name";
            comboBoxPriorite.DataSource = Enum.GetValues(typeof(Priorite));
            comboBoxEtat.DataSource = Enum.GetValues(typeof (GestionCommande));

            gridViewOrderLine.Columns[0].FieldName = "Product.Name";

            if (!newBdc)
            {
                IdOrder = bdc.Id;
                textEditNumCommande.Text = bdc.NumCommande.ToString(CultureInfo.InvariantCulture);
                comboBoxClients.SelectedValue = bdc.NameClient;
                dateEditLivraison.Text = bdc.DateLivraison.ToShortDateString();
                memoEditAdresssLivraion.Text = bdc.AdresseLivraison;
                comboBoxPriorite.SelectedItem = bdc.Priorite;
                comboBoxEtat.SelectedItem = bdc.Etat;
                dateEditCommande.Text = bdc.Datecommande.ToShortDateString();
                var orderline1 = new OrderLine();
                foreach (var lc in bdc.OrderLines)
                {
                    orderline1.id = lc.Id;
                    orderline1.Product = lc.Product;
                    orderline1.Quantity = lc.Quantity;
                    OrderLines.Add(new OrderLine{id = lc.Id, Product = lc.Product, Quantity = lc.Quantity});
                }
                radiogroupLivraisonSurPlace.EditValue = bdc.LivraisonSurPlace;
                GCOrderLine.DataSource = OrderLines;
            }
            else
            {
                GCOrderLine.DataSource = OrderLines;
            }

            IsBdcModified = false;
            _newBdc = newBdc;
            _sourceBdc = bdc;
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
            IsBdcModified = false;

            if (_newBdc)
            {
                _editBdcPresenter.Write(Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client,
                                    dateEditLivraison.DateTime, memoEditAdresssLivraion.Text,
                                    (Priorite) comboBoxPriorite.SelectedItem,
                                    (GestionCommande) comboBoxEtat.SelectedItem,
                                    Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), dateEditCommande.DateTime,
                                    OrderLines);
                MessageBox.Show(Resources.succesAdd);
            }
            else
            {
                _editBdcPresenter.Write(IdOrder, Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client,
                                    dateEditLivraison.DateTime, memoEditAdresssLivraion.Text,
                                    (Priorite)comboBoxPriorite.SelectedItem,
                                    (GestionCommande)comboBoxEtat.SelectedItem,
                                    Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), dateEditCommande.DateTime,
                                    OrderLines);
                MessageBox.Show(Resources.succesUpdate);
            }
        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            IsBdcModified = false;

            if (_newBdc)
            {
                _editBdcPresenter.Write(Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client,
                                    dateEditLivraison.DateTime, memoEditAdresssLivraion.Text,
                                    (Priorite)comboBoxPriorite.SelectedItem,
                                    (GestionCommande)comboBoxEtat.SelectedItem,
                                    Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), dateEditCommande.DateTime,
                                    OrderLines);
                MessageBox.Show(Resources.succesAdd);
            }
            else
            {
                _editBdcPresenter.Write(IdOrder, Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client,
                                    dateEditLivraison.DateTime, memoEditAdresssLivraion.Text,
                                    (Priorite)comboBoxPriorite.SelectedItem,
                                    (GestionCommande)comboBoxEtat.SelectedItem,
                                    Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), dateEditCommande.DateTime,
                                    OrderLines);
                MessageBox.Show(Resources.succesUpdate);
            }

            Close();
        }

        private void bbiEfaccer_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNumCommande.Text = "";
            comboBoxClients.Text = "";
            comboBoxPriorite.Text = "";
            comboBoxEtat.Text = "";
            memoEditAdresssLivraion.Text = "";
            dateEditLivraison.Text = "";
            dateEditCommande.Text = "";
            radiogroupLivraisonSurPlace.EditValue = "";
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

        public class ModelViewOrderLine
        {
            public string Produit { get; set; }
            public int Quantity { get; set; }

        }

        private void textEditNumCommande_EditValueChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void dateEditLivraison_EditValueChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void memoEditAdresssLivraion_EditValueChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void comboBoxPriorite_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void comboBoxEtat_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void radiogroupLivraisonSurPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void dateEditCommande_EditValueChanged(object sender, EventArgs e)
        {
            IsBdcModified = true;
        }

        private void FrmEditBdc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsBdcModified)
            {
                DialogResult result = XtraMessageBox.Show(this, TagResources.SaveBeforeClose, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    if (_newBdc)
                    {
                        _editBdcPresenter.Write(Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client,
                                            dateEditLivraison.DateTime, memoEditAdresssLivraion.Text,
                                            (Priorite)comboBoxPriorite.SelectedItem,
                                            (GestionCommande)comboBoxEtat.SelectedItem,
                                            Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), dateEditCommande.DateTime,
                                            OrderLines);
                        MessageBox.Show(Resources.succesAdd);
                    }
                    else
                    {
                        _editBdcPresenter.Write(IdOrder, Convert.ToInt32(textEditNumCommande.Text), comboBoxClients.SelectedItem as Client,
                                            dateEditLivraison.DateTime, memoEditAdresssLivraion.Text,
                                            (Priorite)comboBoxPriorite.SelectedItem,
                                            (GestionCommande)comboBoxEtat.SelectedItem,
                                            Convert.ToBoolean(radiogroupLivraisonSurPlace.Text), dateEditCommande.DateTime,
                                            OrderLines);
                        MessageBox.Show(Resources.succesUpdate);
                    }

                    IsBdcModified = false;
                }
                  
                if (result == DialogResult.Cancel) e.Cancel = true;
            }
        }
    }
}