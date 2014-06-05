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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Modules
{
    public partial class Bdc2 : BaseModule
    {
        public IEnumerable<ModelViewBdc> Orders { get; set; }
        public IEnumerable<Product> Products { get; set; } 
        private readonly RepositoryOrder _repositoryOrder = new RepositoryOrder();
        private readonly RepositoryProduct _repositoryProduct = new RepositoryProduct();
        private BdcPresenterPage _bdcPresenter;
        public ModelViewBdc _order { get; set; }
        
        public Bdc2()
        {
            InitializeComponent();
            _bdcPresenter = new BdcPresenterPage(this, _repositoryOrder, _repositoryProduct);
            _bdcPresenter.Diplay();

            gridControlOrder.DataSource = Orders;
            gridViewOrder.Columns[0].Visible = false;
            gridViewOrder.RowCellClick += gridViewOrder_CellClick;
            
            gridControlOrderLine.DataSource = Orders.First().OrderLines;
            gridViewOrderLine.Columns[2].Visible = false;
            gridViewOrderLine.Columns[3].Visible = false;
            gridViewOrderLine.Columns[0].Caption = Resources.Produit;
            
            GCDisplayProduct.DataSource = Orders.First().Products;

            layoutViewProduct.Columns["Id"].Visible = false;

            var riPictureEdit = GCDisplayProduct.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
           
            if (riPictureEdit != null)
            {
                riPictureEdit.SizeMode = PictureSizeMode.Squeeze;
                layoutViewProduct.Columns["Photo"].ColumnEdit = riPictureEdit;
            }

            layoutViewProduct.Columns["Photo"].LayoutViewField.TextVisible = false;

            layoutViewProduct.CardMinSize = new Size(350, 200);
        }

        protected internal override void ButtonClick(string tag)
        {
            switch (tag)
            {
                case TagResources.NewBdc:
                    CreateBdc();
                    break;
                case TagResources.ModifyBdc:
                    ModifyBdc(_order);
                    break;
                case TagResources.DeleteBdc:
                    DeleteBdc();
                    break;
                case TagResources.Refresh:
                    RefreshBdc();
                    break;
                case TagResources.Close:
                    Close();
                    break;
            }
        }

        private void CreateBdc()
        {
            var bdc = new ModelViewBdc();
            EditBdc(bdc, true, null);
        }

        private void ModifyBdc(ModelViewBdc bdc)
        {
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
            var bdc = new ModelViewBdc();
            Bdc2_Load(bdc, new EventArgs());
        }

        private void RefreshBdc()
        {
            var bdc = new ModelViewBdc();
            Bdc2_Load(bdc, new EventArgs());
        }

        private void Close()
        {
            
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
            _bdcPresenter = new BdcPresenterPage(this, _repositoryOrder,_repositoryProduct);
            _bdcPresenter.Diplay();

            gridControlOrder.DataSource = Orders;
            gridViewOrder.Columns[0].Visible = false;
            gridViewOrder.RowCellClick += gridViewOrder_CellClick;

            gridControlOrderLine.DataSource = Orders.First().OrderLines;
            gridViewOrderLine.Columns[2].Visible = false;
            gridViewOrderLine.Columns[0].Caption = Resources.Produit;
            gridViewOrderLine.RowCellClick += gridViewOrderLine_CellClick;
            /*
            GCDisplayProduct.DataSource = Products;

            layoutViewProduct.Columns["Id"].Visible = false;

            var riPictureEdit = GCDisplayProduct.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;

            if (riPictureEdit != null)
            {
                riPictureEdit.SizeMode = PictureSizeMode.Squeeze;
                layoutViewProduct.Columns["Photo"].ColumnEdit = riPictureEdit;
            }

            layoutViewProduct.Columns["Photo"].LayoutViewField.TextVisible = false;

            layoutViewProduct.CardMinSize = new Size(350, 200);*/
        }

        private void gridControlOrder_Click(object sender, EventArgs e)
        {
            if (gridViewOrder == null) return;
            gridControlOrderLine.DataSource =
                Orders.First(o => o.Id == (Guid) gridViewOrder.GetFocusedRowCellValue("Id")).OrderLines;
        }

        //To accomplish this task, set the GridView.OptionsBehavior.EditorShowMode property to the EditorShowMode.MouseUp value.
        private void gridViewOrder_CellClick(object sender, RowCellClickEventArgs e)
        {
            if (gridViewOrder == null) return;
            gridControlOrderLine.DataSource =
                Orders.First(o => o.Id == (Guid)gridViewOrder.GetFocusedRowCellValue("Id")).OrderLines;
        }

        private void gridViewOrder_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewOrder == null) return;
            var order = (ModelViewBdc)gridViewOrder.GetFocusedRow();
            //var idorder = (Guid)gridViewOrder.GetFocusedRowCellValue("Id");
            //var order = _repositoryOrder.FindBy(idorder);
            ModifyBdc(order);
        }

        private void gridControlOrderLine_Click(object sender, EventArgs e)
        {
            if (gridViewOrderLine == null) return;
            GCDisplayProduct.DataSource =
                Orders.First(o => o.Id == (Guid)gridViewOrder.GetFocusedRowCellValue("Id")).OrderLines.First(ol => ol.Id == (Guid)gridViewOrderLine.GetFocusedRowCellValue("Id")).Product;
        }

        private void gridViewOrderLine_CellClick(object sender, RowCellClickEventArgs e)
        {
            if (gridViewOrder == null) return;
            GCDisplayProduct.DataSource =
                Orders.First(o => o.Id == (Guid)gridViewOrder.GetFocusedRowCellValue("Id")).OrderLines.First(p => p.Id == (Guid)gridViewOrderLine.GetFocusedRowCellValue("Id")).Product;
        }
    }
}
