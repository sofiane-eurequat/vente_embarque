using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmOrderLine : RibbonForm, IEditBdcView
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Stock> Stocks { get; set; }
        private EditBdcPresenterPage editBdcPresenter;

        public frmOrderLine()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
        /*
        public frmOrderLine(ModelViewOrderLine orderLine)
        {
            InitializeComponent();
            var repositorySecteur = new RepositorySector();
            editBdcPresenter = new EditBdcPresenterPage(this, repositoryWilaya, repositoryAgentTerrain, repositorySecteur, repositoryClient);
            editSecteurPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";
        }*/

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            //editBdcPresenter.Write(comboBoxStock,textEditProduit.EditValue.ToString(), textEditQuantité.EditValue.ToString(),);
        }
        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Close();
        }
        private void bbiEfaccer_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditProduit.Text = "";
            textEditQuantité.Text = "";
        }

        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}