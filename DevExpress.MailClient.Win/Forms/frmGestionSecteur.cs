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
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter;
using vente_embarque.presenter.Secteur;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmGestionSecteur : RibbonForm, IEditSecteurView
    {
        public IEnumerable<Wilaya> Wilayas { get; set; }
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
            var RepositoryWilaya = new RepositoryWilaya();
            editSecteurPresenter = new EditSecteurPresenterPage(this, RepositoryWilaya);
            editSecteurPresenter.Display();

            comboBoxWilaya.DataSource = Wilayas;

            this.newSecteur = newSecteur;
            DialogResult = DialogResult.Cancel;
            sourceSecteur = Secteur;
        }
    }
}