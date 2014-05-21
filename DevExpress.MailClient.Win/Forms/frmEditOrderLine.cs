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

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmEditOrderLine : RibbonForm, IEditBdcView
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public OrderLine OrderLine { get; set; }
        private bool _newOrderLine = true;
        private bool _isOrderLineModified;

        private EditOrderLinePresenterPage editOrderLinePresenter;

        public frmEditOrderLine(OrderLine orderLine, bool newOrderLine)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            _newOrderLine = newOrderLine;
            if (_newOrderLine) 
            {
                _isOrderLineModified = true;
            }
            else
            {
                _isOrderLineModified = false;
            }
            var repositoryStock = new RepositoryStock();
            editOrderLinePresenter = new EditOrderLinePresenterPage(this, repositoryStock);
            editOrderLinePresenter.Display();

            comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            comboBoxStock.DisplayMember = "Name";

            comboBoxProduit.DataSource = Stocks.First(s => s.Name == (string)comboBoxStock.SelectedValue).GetProducts().ToList();
            comboBoxProduit.DisplayMember = "Name";
        }

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
           // frmBdc
        }
        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrderLine = FactoryOrder.CreateOrderLine(comboBoxStock.SelectedItem as Stock, comboBoxProduit.Text,
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
            comboBoxProduit.DataSource = Stocks.First(s => s.Name == (string) comboBoxStock.SelectedValue).GetProducts().ToList();
        }
        
        DialogResult QueryDelete()
        {
            DialogResult result = XtraMessageBox.Show(this, TagResources.DeleteQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (result)
            {
                case DialogResult.Cancel:
                    return DialogResult.Cancel;
                case DialogResult.No:
                    return DialogResult.No;
                default:
                   // DeleteRecord();
                    return DialogResult.Yes;
            }
        }

        DialogResult QueryClose()
        {
            if (!_isOrderLineModified)
                return DialogResult.Yes;

            DialogResult result = XtraMessageBox.Show(this, TagResources.SaveQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (result)
            {
                case DialogResult.Cancel:
                    return DialogResult.Cancel;
                case DialogResult.No:
                    return DialogResult.No;
                default:
                    ApplyChanges();
                    return DialogResult.Yes;
            }
        }

        private void ApplyChanges()
        {
            throw new NotImplementedException();
        }
    }
}