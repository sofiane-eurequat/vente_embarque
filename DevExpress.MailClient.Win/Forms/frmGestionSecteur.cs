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
using vente_embarque.Core.Domain;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter;
using vente_embarque.presenter.Secteur;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmGestionSecteur : RibbonForm, IEditSecteurView
    {
        public IEnumerable<Wilaya> Wilayas { get; set; }
        public IEnumerable<AgentTerrain> AgentTerrains { get; set; }
        public IEnumerable<Client> Clients { get; set; } 
        public Sector Secteurs { get; set; }
        private EditSecteurPresenterPage editSecteurPresenter;
        readonly ModelViewSecteur sourceSecteur;
        bool newSecteur = true;

        public frmGestionSecteur() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public frmGestionSecteur(ModelViewSecteur Secteur, bool newSecteur, string caption)
        {
            InitializeComponent();
            //DictionaryHelper.InitDictionary(spellChecker1);
            var repositoryWilaya = new RepositoryWilaya();
            var repositoryAgentTerrain = new RepositoryAgentTerrain();
            var repositorySecteur = new RepositorySector();
            var repositoryClient = new RepositoryClient();
            editSecteurPresenter = new EditSecteurPresenterPage(this, repositoryWilaya, repositoryAgentTerrain, repositorySecteur, repositoryClient);
            editSecteurPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";
            comboBoxWilaya.DataSource = Wilayas.OrderBy(c=>c.Code).ToList();
            comboBoxWilaya.ValueMember = "Code";
            comboBoxCommune.DataSource = Wilayas.First(w=>w.Code==(int)comboBoxWilaya.SelectedValue).Communes.OrderBy(c=>c.Name).ToList();
            comboBoxCommune.DisplayMember = "Name";

            this.newSecteur = newSecteur;
            DialogResult = DialogResult.Cancel;
            sourceSecteur = Secteur;

            GCAgentTerrain.DataSource = AgentTerrains;
        }

        private void comboBoxWilaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxWilaya.ValueMember = "Code";
            comboBoxCommune.DataSource = Wilayas.First(w => w.Code == (int)comboBoxWilaya.SelectedValue).Communes.OrderBy(c => c.Name).ToList();
        }

        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            editSecteurPresenter.Write(textEditSecteur.EditValue.ToString(),comboBoxWilaya.Text,comboBoxCommune.Text);
        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            editSecteurPresenter.Write(textEditSecteur.EditValue.ToString(), comboBoxWilaya.Text, comboBoxCommune.Text);
            Close();
        }

        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiEffacer_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditSecteur.Text = "";
            comboBoxClients.Text = "";
            comboBoxWilaya.Text = "";
            comboBoxCommune.Text = "";

        }

        private void bbiSuppAgentTerrain_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}