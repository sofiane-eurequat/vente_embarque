using System;
using System.Collections.Generic;
using System.Globalization;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.Model.Enum;
using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class FrmEditProduct : RibbonForm
    {
        private readonly EditProductPresenterPage _editProductPresenter;
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Marque> Marques { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public Guid IdProduct { get; set; }
        readonly bool _newProduct = true;

        public FrmEditProduct(ModelViewProduct product, bool newProduct)
        {
            InitializeComponent();

            var repositoryCategory = new RepositoryCategory();
            var repositoryMarque = new RepositoryMarque();
            var repositoryProduit = new RepositoryProduct();

            _editProductPresenter=new EditProductPresenterPage(this,repositoryCategory,repositoryMarque,repositoryProduit);
            _editProductPresenter.Display();

            comboBoxCategory.DataSource = Categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxMarque.DataSource = Marques;
            comboBoxMarque.DisplayMember = "Name";
            comboBoxTypeGestion.DataSource = Enum.GetValues(typeof (GestionProduit));

            if (!newProduct)
            {
                IdProduct = product.Id;
                textEditNameProduct.Text = product.Nom;
                comboBoxCategory.SelectedValue = product.Categorie;
                comboBoxMarque.SelectedValue = product.Marque;
                textEditFournisseur.Text = product.Fournisseur;
                textEditQuantité.Text = product.QuantiteMin.ToString(CultureInfo.InvariantCulture);
                dateEditEntree.Text = product.DateEntree.ToShortDateString();
                comboBoxTypeGestion.SelectedItem = product.TypeGestion;
            }

            _newProduct = newProduct;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_newProduct)
            {
                _editProductPresenter.Write(textEditNameProduct.Text, comboBoxCategory.SelectedItem as Category,
                                        comboBoxMarque.SelectedItem as Marque, textEditFournisseur.Text,
                                        Convert.ToInt32(textEditQuantité.Text), dateEditEntree.DateTime,
                                        (GestionProduit) comboBoxTypeGestion.SelectedItem);
            }
            else
            {
                _editProductPresenter.Write(IdProduct,textEditNameProduct.Text, comboBoxCategory.SelectedItem as Category,
                                        comboBoxMarque.SelectedItem as Marque, textEditFournisseur.Text,
                                        Convert.ToInt32(textEditQuantité.Text), dateEditEntree.DateTime,
                                        (GestionProduit)comboBoxTypeGestion.SelectedItem);
            }
            
        }

        private void bbiSaveClsoe_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editProductPresenter.Write(textEditNameProduct.Text, comboBoxCategory.SelectedItem as Category,
                                        comboBoxMarque.SelectedItem as Marque, textEditFournisseur.Text,
                                        Convert.ToInt32(textEditQuantité.Text), dateEditEntree.DateTime,
                                        (GestionProduit) comboBoxTypeGestion.SelectedItem);
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