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

namespace DevExpress.MailClient.Win.Forms
{
    public partial class FrmEditOrderLine : RibbonForm
    {
        private IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public OrderLine OrderLine { get; set; }
        private readonly bool _newOrderLine;
        private bool _isOrderLineModified;
        public ModelViewOrderLine OrderLineOut;

        public FrmEditOrderLine(IEnumerable<Stock> stocks, ModelViewOrderLine orderLine, bool newOrderLine)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Stocks = stocks;
            OrderLineOut = orderLine;
            _newOrderLine = newOrderLine;
            if (_newOrderLine) 
            {
                _isOrderLineModified = true;
            }
            else
            {
                _isOrderLineModified = false;
            }

            comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            comboBoxStock.DisplayMember = "Name";

            if (!Stocks.Any()) return;
            comboBoxProduit.DataSource = Stocks.First(s => s.Name == (string)comboBoxStock.SelectedValue).GetProducts().ToList();
            comboBoxProduit.DisplayMember = "Name";

            if (!newOrderLine)
            {
                //comboBoxStock.SelectedValue = orderLine.Product.s
                comboBoxProduit.SelectedValue = orderLine.ProductName;
                textEditQuantité.Text = orderLine.Quantity.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
           // frmBdc
        }
        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isOrderLineModified = false;
            //DialogResult result = QueryClose();
            if (_newOrderLine)
            {
                OrderLine = FactoryOrder.CreateOrderLine(comboBoxStock.SelectedItem as Stock, comboBoxProduit.Text,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
            }
            else
            {
                var orderLineModif = new OrderLine
                    {
                    id = OrderLineOut.Id,
                    Product = comboBoxProduit.SelectedItem as Product,
                    Quantity = Convert.ToInt32(textEditQuantité.EditValue.ToString())
                };

                var repositoryOrder = new RepositoryOrder();
                repositoryOrder.Save(OrderLineOut.IdOrder, orderLineModif);
            }
        }
        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isOrderLineModified = false;
            DialogResult result = QueryClose();
            if (_newOrderLine)
            {
                OrderLine = FactoryOrder.CreateOrderLine(comboBoxStock.SelectedItem as Stock, comboBoxProduit.Text,
                                                     Convert.ToInt32(textEditQuantité.EditValue.ToString()));
            }
            else
            {
                var orderLineModif = new OrderLine
                {
                    id = OrderLineOut.Id,
                    Product = comboBoxProduit.SelectedItem as Product,
                    Quantity = Convert.ToInt32(textEditQuantité.EditValue.ToString())
                };

                var repositoryOrder = new RepositoryOrder();
                repositoryOrder.Save(OrderLineOut.IdOrder, orderLineModif);
            }

            if (result == DialogResult.Yes) Close();
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
            _isOrderLineModified = true;
        }

        private void comboBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isOrderLineModified = true;
        }

        private void textEditQuantité_EditValueChanged(object sender, EventArgs e)
        {
            _isOrderLineModified = true;
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