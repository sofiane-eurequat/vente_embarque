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
using DevExpress.MailClient.Win.Properties;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Modules
{
    public partial class Bdc2 : BaseModule
    {
        public IEnumerable<ModelViewBdc> Orders { get; set; }
        private readonly RepositoryOrder _repositoryOrder = new RepositoryOrder();
        private BdcPresenterPage _bdcPresenter;
        
        public Bdc2()
        {
            InitializeComponent();
            _bdcPresenter = new BdcPresenterPage(this, _repositoryOrder);
            _bdcPresenter.Diplay();

            gridControlOrder.DataSource = Orders;
            gridViewOrder.Columns[0].Visible = false;

            gridControlOrderLine.DataSource = Orders.First().OrderLines;
            gridViewOrderLine.Columns[2].Visible = false;
            gridViewOrderLine.Columns[0].Caption = Resources.Produit;
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
            DialogResult result = XtraMessageBox.Show(this, TagResources.DeleteQuestion, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes)
                return;
            if (gridViewOrder == null) return;
            var idorder = (Guid)gridViewOrder.GetFocusedRowCellValue("Id"); 
            _repositoryOrder.Remove(idorder);
            gridControlOrder.RefreshDataSource();
        }

        private void EditBdc(ModelViewBdc bdc, bool newBdc, string caption)
        {
            Cursor.Current = Cursors.WaitCursor;
            var form = new frmBdc(bdc, newBdc, caption);
            form.Location = new Point(OwnerForm.Left + (OwnerForm.Width - form.Width) / 2, OwnerForm.Top + (OwnerForm.Height - form.Height) / 2);
            form.ShowDialog();
            Bdc2_Load(bdc,new EventArgs());
            Cursor.Current = Cursors.Default;
        }

        private void Bdc2_Load(object sender, EventArgs e)
        {
            _bdcPresenter = new BdcPresenterPage(this, _repositoryOrder);
            _bdcPresenter.Diplay();

            gridControlOrder.DataSource = Orders;
            gridViewOrder.Columns[0].Visible = false;

            gridControlOrderLine.DataSource = Orders.First().OrderLines;
            gridViewOrderLine.Columns[2].Visible = false;
            gridViewOrderLine.Columns[0].Caption = Resources.Produit;
        }

        private void gridControlOrder_Click(object sender, EventArgs e)
        {
            {
                //var idOrder = gridViewOrder.GetRowCellValue(gridViewOrder.FocusedRowHandle, "Id").ToString();
            }
        }
    }
}
