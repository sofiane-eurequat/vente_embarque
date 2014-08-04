using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraEditors;
using vente_embarque.presenter;
using vente_embarque.presenter.Secteur;
using vente_embarque.DataLayer;

namespace DevExpress.MailClient.Win.Modules
{
    public partial class Sector : BaseModule
    {
        public IEnumerable<ModelViewSecteur> Secteurs { get; set; }
        private readonly RepositorySector _repositorySector = new RepositorySector();
        private SecteurPresenterPage _secteurPresenter;
        public ModelViewSecteur Secteur { get; set; }
        
        public Sector()
        {
            InitializeComponent();
        }

        protected internal override void ButtonClick(string tag)
        {
            switch (tag)
            {
                case TagResources.NewSecteur:
                    CreateSecteur();
                    break;
                case TagResources.ModifySecteur:
                    ModifySecteur(Secteur);
                    break;
                case TagResources.DeleteProduct:
                    DeleteSecteur();
                    break;
                case TagResources.Refresh:
                    RefreshSecteur();
                    break;
                case TagResources.Close:
                    Close();
                    break;
            }
        }

        private void CreateSecteur()
        {
            var secteur = new ModelViewSecteur();
            EditSecteur(secteur, true);
        }

        private void ModifySecteur(ModelViewSecteur secteur)
        {
            if (gridViewSecteur == null) return;
            secteur = (ModelViewSecteur)gridViewSecteur.GetFocusedRow();
            EditSecteur(secteur, false);
        }

        private void DeleteSecteur()
        {
            DialogResult result = XtraMessageBox.Show(this, TagResources.DeleteQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes)
                return;
            if (gridViewSecteur == null) return;
            var idSecteur = (Guid)gridViewSecteur.GetFocusedRowCellValue("Id");
            new RepositorySector().Remove(idSecteur);
            var produit = new ModelViewSecteur();
            Sector_Load(produit, new EventArgs());
        }

        private void RefreshSecteur()
        {
            var produit = new ModelViewSecteur();
            Sector_Load(produit, new EventArgs());
        }

        private static void Close()
        {
            Application.Exit();
        }

        private void EditSecteur(ModelViewSecteur secteur, bool newSecteur)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new FrmEditSector(secteur, newSecteur);
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.Show();
            Cursor.Current = Cursors.Default;
        }

        private void Sector_Load(object sender, EventArgs e)
        {
            _secteurPresenter = new SecteurPresenterPage(this, _repositorySector);
            _secteurPresenter.Display();

            gridControlSecteur.DataSource = Secteurs;
            gridViewSecteur.Columns["Id"].Visible = false;
            gridViewSecteur.Columns["CodeWilaya"].Visible = false;
        }

        //To accomplish this task, set the GridView.OptionsBehavior.EditorShowMode property to the EditorShowMode.MouseUp value.
        private void gridViewProduct_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewSecteur == null) return;
            var product = (ModelViewSecteur)gridViewSecteur.GetFocusedRow();
            ModifySecteur(product);
        }
    }
}
