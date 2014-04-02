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
    public partial class frmBdc : RibbonForm, IEditBdcView
    {
        private EditBdcPresenterPage editBdcPresenter;
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        readonly ModelViewBdc sourceBdc;
        bool newBdc = true;

        public frmBdc()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
            
        public frmBdc(ModelViewBdc Bdc, bool newBdc, string caption)
        {
            InitializeComponent();
            var repositoryClient = new RepositoryClient();
            var repositoryStock = new RepositoryStock();
            editBdcPresenter = new EditBdcPresenterPage(this, repositoryClient,repositoryStock);
            editBdcPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";

            //comboBoxStock.DataSource = Stocks.OrderBy(s => s.Name).ToList();
            //comboBoxStock.DisplayMember = "Name";
            this.newBdc = newBdc;
            DialogResult = DialogResult.Cancel;
            sourceBdc = Bdc;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new frmOrderLine();
            //form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.Show();
            Cursor.Current = Cursors.Default;
        }
    }
}