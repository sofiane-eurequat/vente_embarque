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
        private readonly bool _newProductLine = true;
        private bool _isProductLineModified;

        public FrmEditProductLine(ModelViewProductLine productLine, bool newProductLine)
        {
            InitializeComponent();

            var repositoryStock = new RepositoryStock();
            var repositoryProduit = new RepositoryProduct();

            _editProductLinePresenter = new EditProductLinePresenterPage(this,repositoryStock, repositoryProduit);
            _editProductLinePresenter.Display();
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
            comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            comboBoxStock.DisplayMember = "Name";

            comboBoxProduit.DataSource = Products.OrderBy(p => p.Name).ToList();
            comboBoxProduit.DisplayMember = "Name";
        }
        
        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
           // frmBdc
        }
        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isProductLineModified = false;
            _editProductLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
        }
        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
         
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

        private void comboBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStock.ValueMember = "Name";
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