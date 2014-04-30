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
using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmOrderLineAdd : RibbonForm, IEditBdcView
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Product> Produits { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }
        private EditOrderLinePresenterPage editOrderLinePresenter;

        public frmOrderLineAdd()
        {
            InitializeComponent();
            var repositoryProduit = new RepositoryProduct();
            var repositoryStock = new RepositoryStock();
            editOrderLinePresenter = new EditOrderLinePresenterPage(this, repositoryProduit, repositoryStock);
            editOrderLinePresenter.Display();

           // comboBoxProduit.DataSource = Products.OrderBy(cl => cl.Name).ToList();
           // comboBoxProduit.DisplayMember = "Name";

            comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            comboBoxStock.DisplayMember = "Name";
        }

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
           // frmBdc
        }
        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            //editOrderLinePresenter.Write(comboBoxStock.SelectedItem as Stock,comboBoxProduit.SelectedItem as Product, Convert.ToInt32(textEditQuantité.EditValue.ToString()));
            editOrderLinePresenter.Write(comboBoxStock.SelectedItem as Stock,comboBoxProduit.Text, Convert.ToInt32(textEditQuantité.EditValue.ToString()));
        }
        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            //editOrderLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product, Convert.ToInt32(textEditQuantité.EditValue.ToString()));
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
    }
}