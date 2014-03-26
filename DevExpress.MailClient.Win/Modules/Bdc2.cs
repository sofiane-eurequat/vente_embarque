using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Forms;
using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Modules
{
    public partial class Bdc2 : BaseModule
    {
        public Bdc2()
        {
            InitializeComponent();
        }

        protected internal override void ButtonClick(string tag)
        {
            switch (tag)
            {
                case TagResources.NewBdc:
                    CreateBdc();
                    break;
            }
        }

        private void CreateBdc()
        {
            var bdc = new ModelViewBdc();
            EditBdc(bdc, true, null);
        }

        private void EditBdc(ModelViewBdc bdc, bool newBdc, string caption)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new frmBdc(bdc, newBdc, caption);
            //form.Load += OnEditMailFormLoad;
            //form.FormClosed += OnEditMailFormClosed;
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.Show();
            Cursor.Current = Cursors.Default;
        }
    }
}
