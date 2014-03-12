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
            editSecteurPresenter = new EditSecteurPresenterPage(this, repositoryWilaya, repositoryAgentTerrain);
            editSecteurPresenter.Display();

            comboBoxWilaya.DataSource = Wilayas.OrderBy(c=>c.Code).ToList();
            comboBoxWilaya.ValueMember = "Code";
            comboBoxCommune.DataSource = Wilayas.First(w=>w.Code==(int)comboBoxWilaya.SelectedValue).Communes.OrderBy(c=>c.Name).ToList();

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
    }
}