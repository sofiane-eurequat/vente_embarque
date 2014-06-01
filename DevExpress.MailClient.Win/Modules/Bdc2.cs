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
using vente_embarque.DataLayer;
using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Modules
{
    public partial class Bdc2 : BaseModule, IBdcView
    {
        public IEnumerable<ModelViewBdc> Orders { get; set; }
        private readonly RepositoryOrder repositoryOrder = new RepositoryOrder();
        private BdcPresenterPage _BdcPresenter;
        
        public Bdc2()
        {
            InitializeComponent();
            _BdcPresenter = new BdcPresenterPage(this, repositoryOrder);
            _BdcPresenter.Diplay();

            gridControlOrder.DataSource = Orders;
            gridViewOrder.Columns[0].Visible = false;

            gridControlOrderLine.DataSource = Orders.First().OrderLines;
            gridViewOrderLine.Columns[2].Visible = false;
        }

        protected internal override void ButtonClick(string tag)
        {
            switch (tag)
            {
                case TagResources.NewBdc:
                    CreateBdc();
                    break;
                case TagResources.ModifyBdc:
                    ModifyBdc();
                    break;
                case TagResources.DeleteBdc:
                    DeleteBdc();
                    break;
            }
        }

        private void CreateBdc()
        {
            var bdc = new ModelViewBdc();
            EditBdc(bdc, true, null);
        }

        private void ModifyBdc()
        {
            var bdc = new ModelViewBdc();
            EditBdc(bdc, false, null);
        }

        private void DeleteBdc()
        {
            var bdc = new ModelViewBdc();
            EditBdc(bdc, false, null);
        }

        private void EditBdc(ModelViewBdc bdc, bool newBdc, string caption)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new frmBdc(bdc, newBdc, caption);
            //form.Load += OnEditMailFormLoad;
            //form.FormClosed += OnEditMailFormClosed;
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.ShowDialog();
            this.Bdc2_Load(bdc,new EventArgs());
            Cursor.Current = Cursors.Default;
        }

        private void Bdc2_Load(object sender, EventArgs e)
        {
            _BdcPresenter = new BdcPresenterPage(this, repositoryOrder);
            _BdcPresenter.Diplay();

            gridControlOrder.DataSource = Orders;
            gridViewOrder.Columns[0].Visible = false;

            gridControlOrderLine.DataSource = Orders.First().OrderLines;
            gridViewOrderLine.Columns[2].Visible = false;
        }

        private void gridControlOrder_Click(object sender, EventArgs e)
        {
            var gd = gridViewOrderLine.FocusedRowHandle;
            //gridViewOrder.SelectRow();
        }

       // private void gridControlOrder_Click_1(object sender, DataGridViewCellEventArgs e)
        //{
          //  if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.gridViewOrder.Rows[e.RowIndex];
            //}
       // }
    }
}
