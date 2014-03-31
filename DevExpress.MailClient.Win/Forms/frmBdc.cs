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
            editBdcPresenter = new EditBdcPresenterPage(this, repositoryClient);
            editBdcPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";

            this.newBdc = newBdc;
            DialogResult = DialogResult.Cancel;
            sourceBdc = Bdc;
        }
    }
}