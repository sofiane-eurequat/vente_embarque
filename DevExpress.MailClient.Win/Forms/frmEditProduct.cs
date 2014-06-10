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
    public partial class frmEditProduct : RibbonForm
    {
        private EditProductPresenterPage editProductPresenter;
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Marque> Marques { get; set; }

        public frmEditProduct()
        {
            InitializeComponent();

            var repositoryCategory = new RepositoryCategory();
            var repositoryMarque = new RepositoryMarque();
            var repositoryProduit = new RepositoryProduct();

            editProductPresenter=new EditProductPresenterPage(this,repositoryCategory,repositoryMarque,repositoryProduit);
            editProductPresenter.Display();

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
            editProductPresenter.Write(textEditNameProduct.Text,comboBoxCategory.SelectedItem as Category, comboBoxMarque.SelectedItem as Marque,textEditFournisseur.Text,Convert.ToInt32(textEditQuantité.Text), (GestionProduit)comboBoxTypeGestion.SelectedItem);
        }

        private void bbiSaveClsoe_ItemClick(object sender, ItemClickEventArgs e)
        {
            editProductPresenter.Write(textEditNameProduct.Text, comboBoxCategory.SelectedItem as Category, comboBoxMarque.SelectedItem as Marque, textEditFournisseur.Text, Convert.ToInt32(textEditQuantité.Text), (GestionProduit)comboBoxTypeGestion.SelectedItem);
            Close();
        }

        private void bbiClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNameProduct.Text = "";
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