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

namespace DevExpress.MailClient.Win.Modules
{
    public partial class Secteur : BaseModule
    {
        public Secteur()
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
            }
        }

        private void CreateSecteur()
        {
            var secteur = new ModelViewSecteur();
            EditSecteur(secteur, true, null);
        }

        private void EditSecteur(ModelViewSecteur secteur, bool newSecteur, string caption)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmEditSector form = new frmEditSector(secteur, newSecteur, caption);
            //form.Load += OnEditMailFormLoad;
            //form.FormClosed += OnEditMailFormClosed;
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.Show();
            Cursor.Current = Cursors.Default;
        }
    }
}
