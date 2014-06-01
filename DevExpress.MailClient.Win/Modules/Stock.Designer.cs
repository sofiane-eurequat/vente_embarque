namespace DevExpress.MailClient.Win.Modules {
    partial class Stock {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.splitmain = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCProductDisplay = new DevExpress.XtraGrid.GridControl();
            this.modelViewProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LayoutViewProduct = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colQuantiteMin = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colQuantiteMin = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPhoto = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPhoto = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFournisseur = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFournisseur = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCategorie = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCategorie = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colRemarque = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colRemarque = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colReference = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colReference = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colNom = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colNom = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.Group1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.icEditors = new DevExpress.Utils.ImageCollection(this.components);
            this.ilColumns = new System.Windows.Forms.ImageList(this.components);
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).BeginInit();
            this.splitmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCProductDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelViewProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuantiteMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRemarque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitmain
            // 
            resources.ApplyResources(this.splitmain, "splitmain");
            this.splitmain.Horizontal = false;
            this.splitmain.Name = "splitmain";
            this.splitmain.Panel1.Controls.Add(this.gridControlStock);
            resources.ApplyResources(this.splitmain.Panel1, "splitmain.Panel1");
            this.splitmain.Panel2.Controls.Add(this.splitContainerControl1);
            resources.ApplyResources(this.splitmain.Panel2, "splitmain.Panel2");
            this.splitmain.SplitterPosition = 182;
            // 
            // gridControlStock
            // 
            resources.ApplyResources(this.gridControlStock, "gridControlStock");
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStock});
            // 
            // gridViewStock
            // 
            this.gridViewStock.GridControl = this.gridControlStock;
            this.gridViewStock.Name = "gridViewStock";
            this.gridViewStock.OptionsView.ShowGroupPanel = false;
            // 
            // splitContainerControl1
            // 
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlProduct);
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel2.Controls.Add(this.GCProductDisplay);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.SplitterPosition = 402;
            // 
            // gridControlProduct
            // 
            resources.ApplyResources(this.gridControlProduct, "gridControlProduct");
            this.gridControlProduct.MainView = this.gridViewProductLine;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductLine});
            // 
            // gridViewProductLine
            // 
            this.gridViewProductLine.GridControl = this.gridControlProduct;
            this.gridViewProductLine.Name = "gridViewProductLine";
            this.gridViewProductLine.OptionsFind.AlwaysVisible = true;
            this.gridViewProductLine.OptionsView.ShowGroupPanel = false;
            // 
            // GCProductDisplay
            // 
            this.GCProductDisplay.DataSource = this.modelViewProductBindingSource;
            resources.ApplyResources(this.GCProductDisplay, "GCProductDisplay");
            this.GCProductDisplay.MainView = this.LayoutViewProduct;
            this.GCProductDisplay.Name = "GCProductDisplay";
            this.GCProductDisplay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LayoutViewProduct});
            // 
            // modelViewProductBindingSource
            // 
            this.modelViewProductBindingSource.DataSource = typeof(vente_embarque.presenter.ModelViewProduct);
            // 
            // LayoutViewProduct
            // 
            this.LayoutViewProduct.CardMinSize = new System.Drawing.Size(515, 317);
            this.LayoutViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colQuantiteMin,
            this.colPhoto,
            this.colFournisseur,
            this.colCategorie,
            this.colRemarque,
            this.colReference,
            this.colNom});
            this.LayoutViewProduct.GridControl = this.GCProductDisplay;
            this.LayoutViewProduct.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.LayoutViewProduct.Name = "LayoutViewProduct";
            this.LayoutViewProduct.OptionsBehavior.AllowExpandCollapse = false;
            this.LayoutViewProduct.OptionsBehavior.AllowRuntimeCustomization = false;
            this.LayoutViewProduct.OptionsBehavior.Editable = false;
            this.LayoutViewProduct.OptionsBehavior.ReadOnly = true;
            this.LayoutViewProduct.OptionsCustomization.AllowFilter = false;
            this.LayoutViewProduct.OptionsCustomization.AllowSort = false;
            this.LayoutViewProduct.OptionsItemText.TextToControlDistance = 3;
            this.LayoutViewProduct.OptionsView.ShowCardBorderIfCaptionHidden = false;
            this.LayoutViewProduct.OptionsView.ShowCardExpandButton = false;
            this.LayoutViewProduct.OptionsView.ShowHeaderPanel = false;
            this.LayoutViewProduct.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 20;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colId.Size = new System.Drawing.Size(493, 277);
            this.layoutViewField_colId.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colId.TextToControlDistance = 0;
            this.layoutViewField_colId.TextVisible = false;
            // 
            // colQuantiteMin
            // 
            this.colQuantiteMin.FieldName = "QuantiteMin";
            this.colQuantiteMin.LayoutViewField = this.layoutViewField_colQuantiteMin;
            this.colQuantiteMin.Name = "colQuantiteMin";
            // 
            // layoutViewField_colQuantiteMin
            // 
            this.layoutViewField_colQuantiteMin.EditorPreferredWidth = 222;
            this.layoutViewField_colQuantiteMin.Location = new System.Drawing.Point(0, 46);
            this.layoutViewField_colQuantiteMin.Name = "layoutViewField_colQuantiteMin";
            this.layoutViewField_colQuantiteMin.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colQuantiteMin.Size = new System.Drawing.Size(316, 46);
            this.layoutViewField_colQuantiteMin.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colQuantiteMin.TextSize = new System.Drawing.Size(65, 13);
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.LayoutViewField = this.layoutViewField_colPhoto;
            this.colPhoto.Name = "colPhoto";
            // 
            // layoutViewField_colPhoto
            // 
            this.layoutViewField_colPhoto.EditorPreferredWidth = 127;
            this.layoutViewField_colPhoto.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto";
            this.layoutViewField_colPhoto.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colPhoto.Size = new System.Drawing.Size(153, 139);
            this.layoutViewField_colPhoto.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colPhoto.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPhoto.TextToControlDistance = 0;
            this.layoutViewField_colPhoto.TextVisible = false;
            // 
            // colFournisseur
            // 
            this.colFournisseur.FieldName = "Fournisseur";
            this.colFournisseur.LayoutViewField = this.layoutViewField_colFournisseur;
            this.colFournisseur.Name = "colFournisseur";
            // 
            // layoutViewField_colFournisseur
            // 
            this.layoutViewField_colFournisseur.EditorPreferredWidth = 159;
            this.layoutViewField_colFournisseur.Location = new System.Drawing.Point(0, 139);
            this.layoutViewField_colFournisseur.Name = "layoutViewField_colFournisseur";
            this.layoutViewField_colFournisseur.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colFournisseur.Size = new System.Drawing.Size(248, 46);
            this.layoutViewField_colFournisseur.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colFournisseur.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colCategorie
            // 
            this.colCategorie.FieldName = "Categorie";
            this.colCategorie.LayoutViewField = this.layoutViewField_colCategorie;
            this.colCategorie.Name = "colCategorie";
            // 
            // layoutViewField_colCategorie
            // 
            this.layoutViewField_colCategorie.EditorPreferredWidth = 160;
            this.layoutViewField_colCategorie.Location = new System.Drawing.Point(248, 139);
            this.layoutViewField_colCategorie.Name = "layoutViewField_colCategorie";
            this.layoutViewField_colCategorie.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colCategorie.Size = new System.Drawing.Size(249, 46);
            this.layoutViewField_colCategorie.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colCategorie.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colRemarque
            // 
            this.colRemarque.FieldName = "Remarque";
            this.colRemarque.LayoutViewField = this.layoutViewField_colRemarque;
            this.colRemarque.Name = "colRemarque";
            // 
            // layoutViewField_colRemarque
            // 
            this.layoutViewField_colRemarque.EditorPreferredWidth = 408;
            this.layoutViewField_colRemarque.Location = new System.Drawing.Point(0, 231);
            this.layoutViewField_colRemarque.Name = "layoutViewField_colRemarque";
            this.layoutViewField_colRemarque.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colRemarque.Size = new System.Drawing.Size(497, 64);
            this.layoutViewField_colRemarque.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colRemarque.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colReference
            // 
            this.colReference.FieldName = "Reference";
            this.colReference.LayoutViewField = this.layoutViewField_colReference;
            this.colReference.Name = "colReference";
            // 
            // layoutViewField_colReference
            // 
            this.layoutViewField_colReference.EditorPreferredWidth = 408;
            this.layoutViewField_colReference.Location = new System.Drawing.Point(0, 185);
            this.layoutViewField_colReference.Name = "layoutViewField_colReference";
            this.layoutViewField_colReference.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colReference.Size = new System.Drawing.Size(497, 46);
            this.layoutViewField_colReference.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colReference.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colNom
            // 
            this.colNom.FieldName = "Nom";
            this.colNom.LayoutViewField = this.layoutViewField_colNom;
            this.colNom.Name = "colNom";
            // 
            // layoutViewField_colNom
            // 
            this.layoutViewField_colNom.EditorPreferredWidth = 222;
            this.layoutViewField_colNom.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colNom.Name = "layoutViewField_colNom";
            this.layoutViewField_colNom.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colNom.Size = new System.Drawing.Size(316, 46);
            this.layoutViewField_colNom.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colNom.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutViewCard1
            // 
            resources.ApplyResources(this.layoutViewCard1, "layoutViewCard1");
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colPhoto,
            this.layoutViewField_colRemarque,
            this.Group1,
            this.layoutViewField_colFournisseur,
            this.layoutViewField_colCategorie,
            this.layoutViewField_colReference});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            // 
            // Group1
            // 
            resources.ApplyResources(this.Group1, "Group1");
            this.Group1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colNom,
            this.layoutViewField_colQuantiteMin});
            this.Group1.Location = new System.Drawing.Point(153, 0);
            this.Group1.Name = "Group1";
            this.Group1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.Group1.Size = new System.Drawing.Size(344, 139);
            this.Group1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            // 
            // icEditors
            // 
            resources.ApplyResources(this.icEditors, "icEditors");
            this.icEditors.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icEditors.ImageStream")));
            this.icEditors.Images.SetKeyName(0, "Low.png");
            this.icEditors.Images.SetKeyName(1, "High.png");
            this.icEditors.Images.SetKeyName(2, "ReadMessage_13x13.png");
            this.icEditors.Images.SetKeyName(3, "UnreadMessage_13x13.png");
            this.icEditors.Images.SetKeyName(4, "Attachment.png");
            this.icEditors.Images.SetKeyName(5, "Unread.png");
            this.icEditors.Images.SetKeyName(6, "Read.png");
            // 
            // ilColumns
            // 
            this.ilColumns.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilColumns.ImageStream")));
            this.ilColumns.TransparentColor = System.Drawing.Color.Transparent;
            this.ilColumns.Images.SetKeyName(0, "Importance.png");
            this.ilColumns.Images.SetKeyName(1, "Icon.png");
            this.ilColumns.Images.SetKeyName(2, "Attach.png");
            this.ilColumns.Images.SetKeyName(3, "Whatched.png");
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("gridSplitContainer1.Appearance.BackColor")));
            this.gridSplitContainer1.Appearance.Options.UseBackColor = true;
            this.gridSplitContainer1.Grid = null;
            resources.ApplyResources(this.gridSplitContainer1, "gridSplitContainer1");
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // Stock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitmain);
            this.Name = "Stock";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).EndInit();
            this.splitmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCProductDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelViewProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuantiteMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRemarque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection icEditors;
        private System.Windows.Forms.ImageList ilColumns;
        private XtraGrid.GridSplitContainer gridSplitContainer1;
        private XtraEditors.SplitContainerControl splitmain;
        private XtraGrid.GridControl gridControlStock;
        private XtraGrid.Views.Grid.GridView gridViewStock;
        private XtraEditors.SplitContainerControl splitContainerControl1;
        private XtraGrid.GridControl gridControlProduct;
        private XtraGrid.Views.Grid.GridView gridViewProductLine;
        private XtraGrid.GridControl GCProductDisplay;
        private XtraGrid.Views.Layout.LayoutView LayoutViewProduct;
        private System.Windows.Forms.BindingSource modelViewProductBindingSource;
        private XtraGrid.Columns.LayoutViewColumn colId;
        private XtraGrid.Columns.LayoutViewColumn colQuantiteMin;
        private XtraGrid.Columns.LayoutViewColumn colPhoto;
        private XtraGrid.Columns.LayoutViewColumn colFournisseur;
        private XtraGrid.Columns.LayoutViewColumn colCategorie;
        private XtraGrid.Columns.LayoutViewColumn colRemarque;
        private XtraGrid.Columns.LayoutViewColumn colReference;
        private XtraGrid.Columns.LayoutViewColumn colNom;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colQuantiteMin;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhoto;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFournisseur;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategorie;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colRemarque;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colReference;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colNom;
        private XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private XtraLayout.LayoutControlGroup Group1;
    }
}
