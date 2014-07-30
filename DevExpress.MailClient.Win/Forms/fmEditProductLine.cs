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
using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class FrmEditProductLine : RibbonForm
    {
        private readonly EditProductLinePresenterPage _editProductLinePresenter;
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Product> Products { get; set; }
        private readonly bool _newProductLine;
        public bool IsProductLineModified;
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

            IsProductLineModified = false;
        }
        
        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
           // frmBdc
        }
        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            IsProductLineModified = false;

            if (_newProductLine)
            {
                _editProductLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
                MessageBox.Show(Resources.succesAdd);
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
                MessageBox.Show(Resources.succesUpdate);
            }
            
        }
        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            IsProductLineModified = false;

            if (_newProductLine)
            {
                _editProductLinePresenter.Write(comboBoxStock.SelectedItem as Stock, comboBoxProduit.SelectedItem as Product,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
                MessageBox.Show(Resources.succesAdd);
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
                MessageBox.Show(Resources.succesUpdate);
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
            IsProductLineModified = true;
        }

        private void comboBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsProductLineModified = true;
        }

        private void textEditQuantité_EditValueChanged(object sender, EventArgs e)
        {
            IsProductLineModified = true;
        }

        private void FrmEditProductLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsProductLineModified)
            {
                DialogResult result = XtraMessageBox.Show(this, TagResources.SaveBeforeClose, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    var productLineModif = new ProductLine
                    {
                        id = ProductLineOut.Id,
                        Product = comboBoxProduit.SelectedItem as Product,
                        Quantity = Convert.ToInt32(textEditQuantité.EditValue.ToString())
                    };

                    var repositoryStock = new RepositoryStock();
                    repositoryStock.Save(comboBoxStock.SelectedItem as Stock, productLineModif);
                    IsProductLineModified = false;
                    MessageBox.Show(Resources.succesUpdate);
                }
                    
                if (result == DialogResult.Cancel) e.Cancel = true;
            }
        }
    }
}