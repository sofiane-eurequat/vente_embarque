using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmEditProduct : RibbonForm, IEditProductView
    {
        private EditProductPresenterPage editProductPresenter;
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Marque> Marques { get; set; }

        public frmEditProduct()
        {
            InitializeComponent();

            var repositoryStock = new RepositoryStock();
            var repositoryCategory = new RepositoryCategory();
            var repositoryMarque = new RepositoryMarque();

            editProductPresenter=new EditProductPresenterPage(this,repositoryStock,repositoryCategory,repositoryMarque);
            editProductPresenter.Display();

            comboBoxStock.DataSource = Stocks;
            comboBoxStock.DisplayMember = "Name";
            comboBoxCategory.DataSource = Categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxMarque.DataSource = Marques;
            comboBoxMarque.DisplayMember = "Name";
            comboBoxTypeGestion.DataSource = Enum.GetValues(typeof (GestionProduit));

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiSaveClsoe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNameProduct.Text = "";
            comboBoxStock.Text = "";
            comboBoxCategory.Text = "";
            comboBoxMarque.Text = "";
            textEditFournisseur.Text = "";
            textEditQuantité.Text = "";
            dateEditEntree.Text = "";
            comboBoxTypeGestion.Text = "";
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}