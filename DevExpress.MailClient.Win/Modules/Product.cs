using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraEditors;
using vente_embarque.DataLayer;
using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Modules
{
    public partial class Product : BaseModule
    {
        public IEnumerable<ModelViewProduct> Produits { get; set; }
        private readonly RepositoryProduct _repositoryProduct = new RepositoryProduct();
        private ProductPresenterPage _productPresenter;
        public ModelViewProduct Produit { get; set; }

        public Product()
        {
            InitializeComponent();
        }

        protected internal override void ButtonClick(string tag)
        {
            switch (tag)
            {
                case TagResources.NewProduct:
                    CreateProduct();
                    break;
                case TagResources.ModifyBdc:
                    ModifyProduct(Produit);
                    break;
                case TagResources.DeleteBdc:
                    DeleteProduct();
                    break;
                case TagResources.Refresh:
                    RefreshBdc();
                    break;
                case TagResources.Close:
                    Close();
                    break;
            }
        }

        private void CreateProduct()
        {
            var produit = new ModelViewProduct();
            EditProduct(produit, true);
        }

        private void ModifyProduct(ModelViewProduct produit)
        {
            if (gridViewProduct == null) return;
            produit = (ModelViewProduct)gridViewProduct.GetFocusedRow();
            EditProduct(produit, false);
        }

        private void DeleteProduct()
        {
            DialogResult result = XtraMessageBox.Show(this, TagResources.DeleteQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes)
                return;
            if (gridViewProduct == null) return;
            var idProduct = (Guid)gridViewProduct.GetFocusedRowCellValue("Id");
            _repositoryProduct.Remove(idProduct);
            var produit = new ModelViewProduct();
            Product_Load(produit, new EventArgs());
        }

        private void RefreshBdc()
        {
            var produit = new ModelViewProduct();
            Product_Load(produit, new EventArgs());
        }

        private static void Close()
        {
            Application.Exit();
        }

        private void EditProduct(ModelViewProduct product, bool newProduct)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new FrmEditProduct(product, newProduct);
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.ShowDialog();
            Product_Load(product, new EventArgs());
            Cursor.Current = Cursors.Default;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            _productPresenter = new ProductPresenterPage(this, _repositoryProduct);
            _productPresenter.Display();

            gridControlProduct.DataSource = Produits;
        }
    }
}
