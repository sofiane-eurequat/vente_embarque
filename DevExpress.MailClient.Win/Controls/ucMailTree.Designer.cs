namespace DevExpress.MailClient.Win {
    partial class ucMailTree {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMailTree));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImageIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.icFolders = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icFolders)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colType,
            this.colFolder,
            this.colImageIndex,
            this.colData});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.treeList1.SelectImageList = this.icFolders;
            this.treeList1.Size = new System.Drawing.Size(224, 416);
            this.treeList1.TabIndex = 0;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 33;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colType
            // 
            this.colType.Name = "colType";
            // 
            // colFolder
            // 
            this.colFolder.Name = "colFolder";
            // 
            // colImageIndex
            // 
            this.colImageIndex.FieldName = "ImageIndex";
            this.colImageIndex.Name = "colImageIndex";
            // 
            // colData
            // 
            this.colData.FieldName = "colData";
            this.colData.Name = "colData";
            // 
            // icFolders
            // 
            this.icFolders.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icFolders.ImageStream")));
            this.icFolders.Images.SetKeyName(0, "cart-shopping-magasin-icone-5771-16.png");
            this.icFolders.Images.SetKeyName(1, "panier-ajouter-icone-7116-16.png");
            this.icFolders.Images.SetKeyName(2, "modifier-le-panier-icone-4468-16.png");
            this.icFolders.Images.SetKeyName(3, "panier-supprimer-icone-8119-16.png");
            this.icFolders.Images.SetKeyName(4, "panier-icone-6737-16.png");
            this.icFolders.Images.SetKeyName(5, "panier-ajouter-icone-5924-16.png");
            this.icFolders.Images.SetKeyName(6, "modifier-le-panier-icone-4494-16.png");
            this.icFolders.Images.SetKeyName(7, "panier-supprimer-icone-4936-16.png");
            this.icFolders.Images.SetKeyName(8, "boite-corbeille-vente-v-icone-9111-16.png");
            this.icFolders.Images.SetKeyName(9, "calendrier-voir-la-semaine-icone-3673-16.png");
            this.icFolders.Images.SetKeyName(10, "dalerte-attention-avertissement-icone-8189-16.png");
            // 
            // ucMailTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "ucMailTree";
            this.Size = new System.Drawing.Size(224, 416);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icFolders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImageIndex;
        private DevExpress.Utils.ImageCollection icFolders;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
