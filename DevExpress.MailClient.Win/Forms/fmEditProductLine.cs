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
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter.Bdc;
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
        public ModelViewProductLine productLineOut;
        public FrmEditProductLine(ModelViewProductLine productLine, bool newProductLine)
        {
            InitializeComponent();
            _newProductLine = newProductLine;
            var repositoryStock = new RepositoryStock();
            var repositoryProduit = new RepositoryProduct();

            _editProductLinePresenter = new EditProductLinePresenterPage(this,repositoryStock,repositoryProduit);
            _editProductLinePresenter.Display();
            comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            comboBoxStock.DisplayMember = "Name";
            comboBoxStock.ValueMember = "Name";
            comboBoxProduit.DataSource = Products;
            comboBoxProduit.DisplayMember = "Name";
            comboBoxProduit.ValueMember = "Name";

            if (!newProductLine)
            {
                comboBoxStock.SelectedValue = productLine.Stock.Name;
                comboBoxProduit.SelectedValue = productLine.Name;
                textEditQuantité.Text = productLine.Quantity.ToString(CultureInfo.InvariantCulture);
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
            /*
            productLineOut.Stock = comboBoxStock.SelectedItem as Stock;
            productLineOut.Product = comboBoxProduit.SelectedItem as Product;
            productLineOut.Quantity = Convert.ToInt32(textEditQuantité.EditValue.ToString());
            this.DialogResult=DialogResult.OK;
            */
                _editProductLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
        }
        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editProductLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
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