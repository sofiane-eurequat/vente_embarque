using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;

namespace DevExpress.MailClient.Win {
    public partial class Contacts : BaseModule {
        public override string ModuleName { get { return Properties.Resources.ContactsName; } }
        public Contacts() {
            InitializeComponent();
            EditorHelper.InitPersonComboBox(repositoryItemImageComboBox1);
            gridControl1.DataSource = DataHelper.Contacts;
            gridView1.ShowFindPanel();
        }
        protected override DevExpress.XtraGrid.GridControl Grid { get { return gridControl1; } }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            gridControl1.Focus();
            UpdateActionButtons();
            if(firstShow) {
                gridControl1.ForceInitialize();
                GridHelper.SetFindControlImages(gridControl1);
                if(DataHelper.Contacts.Count == 0) UpdateCurrentContact();
            }
        }
        void UpdateActionButtons() {
            OwnerForm.EnableLayoutButtons(gridControl1.MainView != layoutView1);
            OwnerForm.EnableZoomControl(gridControl1.MainView != layoutView1);
        }
        Contact CurrentContact {
            get { return gridView1.GetRow(gridView1.FocusedRowHandle) as Contact; }
        }
        private void gridView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateCurrentContact();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if(e.FocusedRowHandle == GridControl.AutoFilterRowHandle)
                gridView1.FocusedColumn = colName;
            else if(e.FocusedRowHandle >= 0)
                gridView1.FocusedColumn = null;
            UpdateCurrentContact();
        }

        void UpdateCurrentContact() {
            ucContactInfo1.Init(CurrentContact, null);
            gridView1.MakeRowVisible(gridView1.FocusedRowHandle);
            OwnerForm.EnableEditContact(CurrentContact != null);
        }
        protected internal override void ButtonClick(string tag) {
            switch(tag) {
                case TagResources.ContactList:
                    UpdateMainView(gridView1);
                    ClearSortingAndGrouping();
                    break;
                case TagResources.ContactAlphabetical:
                    UpdateMainView(gridView1);
                    ClearSortingAndGrouping();
                    colName.Group();
                    break;
                case TagResources.ContactByState:
                    UpdateMainView(gridView1);
                    ClearSortingAndGrouping();
                    colState.Group();
                    colCity.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    break;
                case TagResources.ContactCard:
                    UpdateMainView(layoutView1);
                    break;
                case TagResources.FlipLayout:
                    layoutControl1.Root.FlipLayout();
                    break;
                case TagResources.ContactDelete:
                    if(CurrentContact == null) return;
                    int index = gridView1.FocusedRowHandle;
                    gridControl1.MainView.BeginDataUpdate();
                    try {
                        DataHelper.Contacts.Remove(CurrentContact);
                    } finally {
                        gridControl1.MainView.EndDataUpdate();
                    }
                    if(index > gridView1.DataRowCount - 1) index--;
                    gridView1.FocusedRowHandle = index;
                    ShowInfo(gridView1);
                    break;
                case TagResources.ContactNew:
                    Contact contact = new Contact();
                    if(EditContact(contact) == DialogResult.OK) {
                        gridControl1.MainView.BeginDataUpdate();
                        try {
                            DataHelper.Contacts.Add(contact);
                        } finally {
                            gridControl1.MainView.EndDataUpdate();
                        }
                        ColumnView view = gridControl1.MainView as ColumnView;
                        if(view != null) {
                            GridHelper.GridViewFocusObject(view, contact);
                            ShowInfo(view);
                        }
                    }
                    break;
                case TagResources.ContactEdit:
                    EditContact(CurrentContact);
                    break;
            }
            UpdateCurrentContact();
        }
        void UpdateMainView(ColumnView view) {
            bool isGrid = view is GridView;
            gridControl1.MainView = view;
            splitterItem1.Visibility = isGrid ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem2.Visibility = isGrid ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            GridHelper.SetFindControlImages(gridControl1);
            UpdateActionButtons();
        }
        private void ClearSortingAndGrouping() {
            gridView1.ClearGrouping();
            gridView1.ClearSorting();
        }
        protected override bool AllowZoomControl { get { return true; } }
        public override float ZoomFactor {
            get { return ucContactInfo1.ZoomFactor; }
            set { 
                ucContactInfo1.ZoomFactor = value;
                SetZoomCaption();
            }
        }
        protected override void SetZoomCaption() {
            base.SetZoomCaption();
            if(ZoomFactor == 1)
                OwnerForm.ZoomManager.SetZoomCaption(Properties.Resources.Picture100Zoom);
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e) {
            if(e.Button == MouseButtons.Left && e.RowHandle >= 0 && e.Clicks == 2) 
                EditContact(CurrentContact);
        }

        private void layoutView1_MouseDown(object sender, MouseEventArgs e) {
            if(e.Clicks == 2 && e.Button == MouseButtons.Left) {
                LayoutViewHitInfo info = layoutView1.CalcHitInfo(e.Location);
                if(info.InCard) {
                    Contact current = layoutView1.GetRow(info.RowHandle) as Contact;
                    if(current != null) {
                        EditContact(current);
                        layoutView1.UpdateCurrentRow();
                    }
                }
            }
        }
        DialogResult EditContact(Contact contact) {
            if(contact == null) return DialogResult.Ignore;
            DialogResult ret = DialogResult.Cancel;
            Cursor.Current = Cursors.WaitCursor;
            using(frmEditContact frm = new frmEditContact(contact, OwnerForm.Ribbon)) {
                ret = frm.ShowDialog(OwnerForm);
            }
            UpdateCurrentContact();
            Cursor.Current = Cursors.Default;
            return ret;
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter && gridView1.FocusedRowHandle >=0)
                EditContact(CurrentContact);
        }
    }
}
