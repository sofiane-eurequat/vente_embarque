using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Properties;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using vente_embarque.Core.Domain;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter;
using vente_embarque.presenter.Secteur;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class FrmEditSector : RibbonForm, IEditSecteurView
    {
        public IEnumerable<Wilaya> Wilayas { get; set; }
        public IEnumerable<AgentTerrain> AgentTerrains { get; set; }
        public IEnumerable<Client> Clients { get; set; } 
        public IEnumerable<Sector> Secteurs { get; set; }
        private readonly EditSectorPresenterPage _editSecteurPresenter;
        readonly ModelViewSecteur _sourceSecteur;
        bool _newSecteur = true;

        public FrmEditSector() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public FrmEditSector(ModelViewSecteur secteur, bool newSecteur, string caption)
        {
            InitializeComponent();
            //DictionaryHelper.InitDictionary(spellChecker1);
            var repositoryWilaya = new RepositoryWilaya();
            var repositoryAgentTerrain = new RepositoryAgentTerrain();
            var repositorySecteur = new RepositorySector();
            var repositoryClient = new RepositoryClient();
            _editSecteurPresenter = new EditSectorPresenterPage(this, repositoryWilaya, repositoryAgentTerrain, repositorySecteur, repositoryClient);
            _editSecteurPresenter.Display();

            comboBoxClients.DataSource = Clients.OrderBy(cl => cl.Name).ToList();
            comboBoxClients.DisplayMember = "Name";
            comboBoxWilaya.DataSource = Wilayas.OrderBy(c=>c.Code).ToList();
            comboBoxWilaya.ValueMember = "Code";
            comboBoxCommune.DataSource = Wilayas.First(w=>w.Code==(int)comboBoxWilaya.SelectedValue).Communes.OrderBy(c=>c.Name).ToList();
            comboBoxCommune.DisplayMember = "Name";

            _newSecteur = newSecteur;
            DialogResult = DialogResult.Cancel;
            _sourceSecteur = secteur;

            GCAgentTerrain.DataSource = AgentTerrains;
        }

        private void comboBoxWilaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxWilaya.ValueMember = "Code";
            comboBoxCommune.DataSource = Wilayas.First(w => w.Code == (int)comboBoxWilaya.SelectedValue).Communes.OrderBy(c => c.Name).ToList();
        }

        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editSecteurPresenter.Write(textEditSecteur.EditValue.ToString(), comboBoxWilaya.SelectedItem as Wilaya, comboBoxCommune.SelectedItem as Commune);
            MessageBox.Show(Resources.succesAdd);
        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            _editSecteurPresenter.Write(textEditSecteur.EditValue.ToString(), comboBoxWilaya.SelectedItem as Wilaya, comboBoxCommune.SelectedItem as Commune);
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
        
        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiSuppAgentTerrain_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show(this, TagResources.DeleteQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes)
                return;
            if (GVAgentTerrain == null) return;
            var agentTerrain = (AgentTerrain)GVAgentTerrain.GetFocusedRow();
            new RepositoryAgentTerrain().Remove(agentTerrain);
            GCAgentTerrain.RefreshDataSource();
        }

        private void bbiAddAgentTerrain_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new FrmEditAgentTerrain();
            form.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
    }
}