using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class FrmEditProductLine : RibbonForm
    {
        private readonly EditProductLinePresenterPage _editProductLinePresenter;
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Product> Products { get; set; }
        private readonly bool _newProductLine;
        private bool _isProductLineModified;
        public ModelViewProductLine ProductLineOut;

        public FrmEditProductLine(ModelViewProductLine productLine, bool newProductLine)
        {
            InitializeComponent();
            _newProductLine = newProductLine;
            ProductLineOut = productLine;
            var repositoryStock = new RepositoryStock();
            var repositoryProduit = new RepositoryProduct();

            _editProductLinePresenter = new EditProductLinePresenterPage(this,repositoryStock,repositoryProduit);
            _editProductLinePresenter.Display();
            
            comboBoxStock.DisplayMember = "Name";
            comboBoxStock.ValueMember = "Name";
            comboBoxProduit.DataSource = Products;
            comboBoxProduit.DisplayMember = "Name";
            comboBoxProduit.ValueMember = "Name";

            if (!newProductLine)
            {
                comboBoxStock.DataSource = Stocks.Where(s => s.Name == productLine.Stock.Name).ToList();
                //comboBoxStock.SelectedValue = productLine.Stock.Name;
                comboBoxProduit.SelectedValue = productLine.Name;
                textEditQuantité.Text = productLine.Quantity.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            }
            /*
            DialogResult = DialogResult.Cancel;
            Stocks = stocks;
            _newOrderLine = newOrderLine;
            if (_newOrderLine) 
            {
                _isOrderLineModified = true;
            }
            else
            {
                _isOrderLineModified = false;
            }
            */
            
        }
        
        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
           // frmBdc
        }
        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isProductLineModified = false;
            DialogResult=DialogResult.OK;
            
            if (_newProductLine)
            {
                _editProductLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
            }
            else
            {
                var productLineModif = new ProductLine
                {
                    id = ProductLineOut.Id,
                    Product = comboBoxProduit.SelectedItem as Product,
                    Quantity = Convert.ToInt32(textEditQuantité.EditValue.ToString())
                };

                var repositoryStock = new RepositoryStock();
                repositoryStock.Save(comboBoxStock.SelectedItem as Stock, productLineModif);
            }
            
        }
        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isProductLineModified = false;
            DialogResult = DialogResult.OK;

            if (_newProductLine)
            {
                _editProductLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
            }
            else
            {
                var productLineModif = new ProductLine
                {
                    id = ProductLineOut.Id,
                    Product = comboBoxProduit.SelectedItem as Product,
                    Quantity = Convert.ToInt32(textEditQuantité.EditValue.ToString())
                };

                var repositoryStock = new RepositoryStock();
                repositoryStock.Save(comboBoxStock.SelectedItem as Stock, productLineModif);
            }

            Close();
        }
        private void bbiEfaccer_ItemClick(object sender, ItemClickEventArgs e)
        {
            comboBoxStock.Text = "";
            comboBoxProduit.Text = "";
            textEditQuantité.Text = "";
        }

        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void comboBoxStock_SelectedValueChanged(object sender, EventArgs e)
        {
            //comboBoxStock.ValueMember = "Name";
            //comboBoxProduit.DataSource = Stocks.First(s => s.Name == (string) comboBoxStock.SelectedValue).GetProducts().ToList();
            _isProductLineModified = true;
        }

        private void comboBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isProductLineModified = true;
        }

        private void textEditQuantité_EditValueChanged(object sender, EventArgs e)
        {
            _isProductLineModified = true;
        }
    }
}