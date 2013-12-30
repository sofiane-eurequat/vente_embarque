namespace DevExpress.MailClient.Win {
    partial class Contacts {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ucContactInfo1 = new DevExpress.MailClient.Win.Controls.ucContactInfo();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colGender = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colEmail = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPhone = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colState = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.Item1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.ucContactInfo1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(717, 447, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // ucContactInfo1
            // 
            resources.ApplyResources(this.ucContactInfo1, "ucContactInfo1");
            this.ucContactInfo1.Name = "ucContactInfo1";
            this.ucContactInfo1.ZoomFactor = 1F;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGender,
            this.colName,
            this.colEmail,
            this.colState,
            this.colPhone,
            this.colCity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), null, resources.GetString("gridView1.GroupSummary2"))});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.PrintHorzLines = false;
            this.gridView1.OptionsPrint.PrintVertLines = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colGender
            // 
            this.colGender.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowFocus = false;
            this.colGender.OptionsColumn.AllowMove = false;
            this.colGender.OptionsColumn.FixedWidth = true;
            this.colGender.OptionsColumn.ShowCaption = false;
            this.colGender.OptionsFilter.AllowAutoFilter = false;
            resources.ApplyResources(this.colGender, "colGender");
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox1.Buttons"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colName
            // 
            resources.ApplyResources(this.colName, "colName");
            this.colName.FieldName = "Name";
            this.colName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colEmail
            // 
            resources.ApplyResources(this.colEmail, "colEmail");
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowFocus = false;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colState
            // 
            resources.ApplyResources(this.colState, "colState");
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.AllowFocus = false;
            this.colState.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colPhone
            // 
            resources.ApplyResources(this.colPhone, "colPhone");
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colCity
            // 
            resources.ApplyResources(this.colCity, "colCity");
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowFocus = false;
            this.colCity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutView1
            // 
            this.layoutView1.CardHorzInterval = 15;
            this.layoutView1.CardMinSize = new System.Drawing.Size(289, 147);
            this.layoutView1.CardVertInterval = 20;
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn5,
            this.layoutViewColumn4});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsFind.AlwaysVisible = true;
            this.layoutView1.OptionsFind.FindFilterColumns = "Name;Email;Address;Phone";
            this.layoutView1.OptionsMultiRecordMode.MultiColumnScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Horizontal;
            this.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.layoutView1_MouseDown);
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.layoutViewColumn1.FieldName = "Photo";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_colGender;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.OptionsColumn.AllowFocus = false;
            this.layoutViewColumn1.OptionsColumn.AllowMove = false;
            this.layoutViewColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.layoutViewColumn1.OptionsColumn.FixedWidth = true;
            this.layoutViewColumn1.OptionsColumn.ShowCaption = false;
            this.layoutViewColumn1.OptionsFilter.AllowAutoFilter = false;
            this.layoutViewColumn1.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.layoutViewColumn1, "layoutViewColumn1");
            // 
            // layoutViewField_colGender
            // 
            this.layoutViewField_colGender.EditorPreferredWidth = 105;
            this.layoutViewField_colGender.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colGender.MaxSize = new System.Drawing.Size(109, 143);
            this.layoutViewField_colGender.MinSize = new System.Drawing.Size(109, 143);
            this.layoutViewField_colGender.Name = "layoutViewField_colGender";
            this.layoutViewField_colGender.Size = new System.Drawing.Size(109, 143);
            this.layoutViewField_colGender.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_colGender.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colGender.TextToControlDistance = 0;
            this.layoutViewField_colGender.TextVisible = false;
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("layoutViewColumn2.AppearanceCell.Font")));
            this.layoutViewColumn2.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.layoutViewColumn2, "layoutViewColumn2");
            this.layoutViewColumn2.FieldName = "Name";
            this.layoutViewColumn2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical;
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_colName;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.OptionsColumn.AllowFocus = false;
            this.layoutViewColumn2.OptionsColumn.ReadOnly = true;
            this.layoutViewColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.layoutViewColumn2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // layoutViewField_colName
            // 
            this.layoutViewField_colName.EditorPreferredWidth = 172;
            this.layoutViewField_colName.Location = new System.Drawing.Point(109, 0);
            this.layoutViewField_colName.Name = "layoutViewField_colName";
            this.layoutViewField_colName.Size = new System.Drawing.Size(176, 20);
            this.layoutViewField_colName.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colName.TextToControlDistance = 0;
            this.layoutViewField_colName.TextVisible = false;
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.FieldName = "Email";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_colEmail;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.OptionsColumn.AllowFocus = false;
            this.layoutViewColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.layoutViewColumn3.OptionsFilter.AllowFilter = false;
            this.layoutViewColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            resources.ApplyResources(this.layoutViewColumn3, "layoutViewColumn3");
            // 
            // layoutViewField_colEmail
            // 
            this.layoutViewField_colEmail.EditorPreferredWidth = 172;
            this.layoutViewField_colEmail.Location = new System.Drawing.Point(109, 50);
            this.layoutViewField_colEmail.Name = "layoutViewField_colEmail";
            this.layoutViewField_colEmail.Size = new System.Drawing.Size(176, 20);
            this.layoutViewField_colEmail.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colEmail.TextToControlDistance = 0;
            this.layoutViewField_colEmail.TextVisible = false;
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.FieldName = "Phone";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_colPhone;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            this.layoutViewColumn5.OptionsColumn.AllowFocus = false;
            this.layoutViewColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.layoutViewColumn5.OptionsFilter.AllowFilter = false;
            this.layoutViewColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            resources.ApplyResources(this.layoutViewColumn5, "layoutViewColumn5");
            // 
            // layoutViewField_colPhone
            // 
            this.layoutViewField_colPhone.EditorPreferredWidth = 172;
            this.layoutViewField_colPhone.Location = new System.Drawing.Point(109, 30);
            this.layoutViewField_colPhone.Name = "layoutViewField_colPhone";
            this.layoutViewField_colPhone.Size = new System.Drawing.Size(176, 20);
            this.layoutViewField_colPhone.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPhone.TextToControlDistance = 0;
            this.layoutViewField_colPhone.TextVisible = false;
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.ColumnEdit = this.repositoryItemMemoEdit1;
            this.layoutViewColumn4.FieldName = "Address";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_colState;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.OptionsColumn.AllowFocus = false;
            this.layoutViewColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.layoutViewColumn4.OptionsFilter.AllowFilter = false;
            this.layoutViewColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            resources.ApplyResources(this.layoutViewColumn4, "layoutViewColumn4");
            // 
            // layoutViewField_colState
            // 
            this.layoutViewField_colState.EditorPreferredWidth = 172;
            this.layoutViewField_colState.Location = new System.Drawing.Point(109, 80);
            this.layoutViewField_colState.Name = "layoutViewField_colState";
            this.layoutViewField_colState.Size = new System.Drawing.Size(176, 63);
            this.layoutViewField_colState.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colState.TextToControlDistance = 0;
            this.layoutViewField_colState.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            resources.ApplyResources(this.layoutViewCard1, "layoutViewCard1");
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colGender,
            this.layoutViewField_colName,
            this.layoutViewField_colEmail,
            this.layoutViewField_colState,
            this.layoutViewField_colPhone,
            this.Item1,
            this.emptySpaceItem1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            // 
            // Item1
            // 
            this.Item1.AllowHotTrack = false;
            resources.ApplyResources(this.Item1, "Item1");
            this.Item1.Location = new System.Drawing.Point(109, 20);
            this.Item1.MaxSize = new System.Drawing.Size(0, 10);
            this.Item1.MinSize = new System.Drawing.Size(10, 10);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(176, 10);
            this.Item1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Item1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.Location = new System.Drawing.Point(109, 70);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(176, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1203, 656);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(872, 644);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ucContactInfo1;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Location = new System.Drawing.Point(877, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(314, 644);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            resources.ApplyResources(this.splitterItem1, "splitterItem1");
            this.splitterItem1.Location = new System.Drawing.Point(872, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 644);
            // 
            // Contacts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.MailClient.Win.Controls.ucContactInfo ucContactInfo1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colGender;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colEmail;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhone;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colState;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.EmptySpaceItem Item1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
