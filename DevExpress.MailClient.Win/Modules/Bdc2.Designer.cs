using vente_embarque.presenter.Bdc;

namespace DevExpress.MailClient.Win.Modules
{
    partial class Bdc2 : IBdcView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlOrder = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlOrderLine = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrderLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colQuantiteMin = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colQuantiteMin1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPhoto = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPhoto1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFournisseur = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFournisseur1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCategorie = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCategorie1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colRemarque = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colRemarque1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colReference = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colReference1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colNom = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colNom1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.Group1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuantiteMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFournisseur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategorie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRemarque1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReference1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOrder
            // 
            this.gridControlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrder.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrder.MainView = this.gridViewOrder;
            this.gridControlOrder.Name = "gridControlOrder";
            this.gridControlOrder.Size = new System.Drawing.Size(962, 202);
            this.gridControlOrder.TabIndex = 0;
            this.gridControlOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrder});
            this.gridControlOrder.Click += new System.EventHandler(this.gridControlOrder_Click);
            // 
            // gridViewOrder
            // 
            this.gridViewOrder.GridControl = this.gridControlOrder;
            this.gridViewOrder.Name = "gridViewOrder";
            this.gridViewOrder.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewOrder.OptionsFind.AlwaysVisible = true;
            this.gridViewOrder.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlOrderLine
            // 
            this.gridControlOrderLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrderLine.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrderLine.MainView = this.gridViewOrderLine;
            this.gridControlOrderLine.Name = "gridControlOrderLine";
            this.gridControlOrderLine.Size = new System.Drawing.Size(455, 301);
            this.gridControlOrderLine.TabIndex = 1;
            this.gridControlOrderLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderLine});
            // 
            // gridViewOrderLine
            // 
            this.gridViewOrderLine.GridControl = this.gridControlOrderLine;
            this.gridViewOrderLine.Name = "gridViewOrderLine";
            this.gridViewOrderLine.OptionsView.ShowGroupPanel = false;
            // 
            // splitMain
            // 
            this.splitMain.Horizontal = false;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.gridControlOrder);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.splitContainerControl1);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(962, 508);
            this.splitMain.SplitterPosition = 202;
            this.splitMain.TabIndex = 2;
            this.splitMain.Text = "splitContainerControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlOrderLine);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlProduct);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(962, 301);
            this.splitContainerControl1.SplitterPosition = 455;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlProduct
            // 
            this.gridControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProduct.Location = new System.Drawing.Point(0, 0);
            this.gridControlProduct.MainView = this.layoutView1;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.Size = new System.Drawing.Size(502, 301);
            this.gridControlProduct.TabIndex = 0;
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(515, 317);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colQuantiteMin,
            this.colPhoto,
            this.colFournisseur,
            this.colCategorie,
            this.colRemarque,
            this.colReference,
            this.colNom});
            this.layoutView1.GridControl = this.gridControlProduct;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId1});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.AllowExpandCollapse = false;
            this.layoutView1.OptionsBehavior.AllowRuntimeCustomization = false;
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsCustomization.AllowFilter = false;
            this.layoutView1.OptionsCustomization.AllowSort = false;
            this.layoutView1.OptionsItemText.TextToControlDistance = 3;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.CustomizationCaption = "Id";
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId1;
            this.colId.Name = "colId";
            // 
            // layoutViewField_colId1
            // 
            this.layoutViewField_colId1.EditorPreferredWidth = 20;
            this.layoutViewField_colId1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId1.Name = "layoutViewField_colId1";
            this.layoutViewField_colId1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colId1.Size = new System.Drawing.Size(497, 295);
            this.layoutViewField_colId1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colId1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colId1.TextToControlDistance = 0;
            this.layoutViewField_colId1.TextVisible = false;
            // 
            // colQuantiteMin
            // 
            this.colQuantiteMin.CustomizationCaption = "Quantite Min";
            this.colQuantiteMin.FieldName = "QuantiteMin";
            this.colQuantiteMin.LayoutViewField = this.layoutViewField_colQuantiteMin1;
            this.colQuantiteMin.Name = "colQuantiteMin";
            // 
            // layoutViewField_colQuantiteMin1
            // 
            this.layoutViewField_colQuantiteMin1.EditorPreferredWidth = 222;
            this.layoutViewField_colQuantiteMin1.Location = new System.Drawing.Point(0, 46);
            this.layoutViewField_colQuantiteMin1.Name = "layoutViewField_colQuantiteMin1";
            this.layoutViewField_colQuantiteMin1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colQuantiteMin1.Size = new System.Drawing.Size(316, 46);
            this.layoutViewField_colQuantiteMin1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colQuantiteMin1.TextSize = new System.Drawing.Size(65, 13);
            // 
            // colPhoto
            // 
            this.colPhoto.CustomizationCaption = "Photo";
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.LayoutViewField = this.layoutViewField_colPhoto1;
            this.colPhoto.Name = "colPhoto";
            // 
            // layoutViewField_colPhoto1
            // 
            this.layoutViewField_colPhoto1.EditorPreferredWidth = 127;
            this.layoutViewField_colPhoto1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colPhoto1.Name = "layoutViewField_colPhoto1";
            this.layoutViewField_colPhoto1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colPhoto1.Size = new System.Drawing.Size(153, 139);
            this.layoutViewField_colPhoto1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colPhoto1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPhoto1.TextToControlDistance = 0;
            this.layoutViewField_colPhoto1.TextVisible = false;
            // 
            // colFournisseur
            // 
            this.colFournisseur.CustomizationCaption = "Fournisseur";
            this.colFournisseur.FieldName = "Fournisseur";
            this.colFournisseur.LayoutViewField = this.layoutViewField_colFournisseur1;
            this.colFournisseur.Name = "colFournisseur";
            // 
            // layoutViewField_colFournisseur1
            // 
            this.layoutViewField_colFournisseur1.EditorPreferredWidth = 159;
            this.layoutViewField_colFournisseur1.Location = new System.Drawing.Point(0, 139);
            this.layoutViewField_colFournisseur1.Name = "layoutViewField_colFournisseur1";
            this.layoutViewField_colFournisseur1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colFournisseur1.Size = new System.Drawing.Size(248, 46);
            this.layoutViewField_colFournisseur1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colFournisseur1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colCategorie
            // 
            this.colCategorie.CustomizationCaption = "Categorie";
            this.colCategorie.FieldName = "Categorie";
            this.colCategorie.LayoutViewField = this.layoutViewField_colCategorie1;
            this.colCategorie.Name = "colCategorie";
            // 
            // layoutViewField_colCategorie1
            // 
            this.layoutViewField_colCategorie1.EditorPreferredWidth = 160;
            this.layoutViewField_colCategorie1.Location = new System.Drawing.Point(248, 139);
            this.layoutViewField_colCategorie1.Name = "layoutViewField_colCategorie1";
            this.layoutViewField_colCategorie1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colCategorie1.Size = new System.Drawing.Size(249, 46);
            this.layoutViewField_colCategorie1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colCategorie1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colRemarque
            // 
            this.colRemarque.CustomizationCaption = "Remarque";
            this.colRemarque.FieldName = "Remarque";
            this.colRemarque.LayoutViewField = this.layoutViewField_colRemarque1;
            this.colRemarque.Name = "colRemarque";
            // 
            // layoutViewField_colRemarque1
            // 
            this.layoutViewField_colRemarque1.EditorPreferredWidth = 408;
            this.layoutViewField_colRemarque1.Location = new System.Drawing.Point(0, 231);
            this.layoutViewField_colRemarque1.Name = "layoutViewField_colRemarque1";
            this.layoutViewField_colRemarque1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colRemarque1.Size = new System.Drawing.Size(497, 64);
            this.layoutViewField_colRemarque1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colRemarque1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colReference
            // 
            this.colReference.CustomizationCaption = "Reference";
            this.colReference.FieldName = "Reference";
            this.colReference.LayoutViewField = this.layoutViewField_colReference1;
            this.colReference.Name = "colReference";
            // 
            // layoutViewField_colReference1
            // 
            this.layoutViewField_colReference1.EditorPreferredWidth = 408;
            this.layoutViewField_colReference1.Location = new System.Drawing.Point(0, 185);
            this.layoutViewField_colReference1.Name = "layoutViewField_colReference1";
            this.layoutViewField_colReference1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colReference1.Size = new System.Drawing.Size(497, 46);
            this.layoutViewField_colReference1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colReference1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colNom
            // 
            this.colNom.CustomizationCaption = "Nom";
            this.colNom.FieldName = "Nom";
            this.colNom.LayoutViewField = this.layoutViewField_colNom1;
            this.colNom.Name = "colNom";
            // 
            // layoutViewField_colNom1
            // 
            this.layoutViewField_colNom1.EditorPreferredWidth = 222;
            this.layoutViewField_colNom1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colNom1.Name = "layoutViewField_colNom1";
            this.layoutViewField_colNom1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewField_colNom1.Size = new System.Drawing.Size(316, 46);
            this.layoutViewField_colNom1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewField_colNom1.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colPhoto1,
            this.layoutViewField_colRemarque1,
            this.Group1,
            this.layoutViewField_colFournisseur1,
            this.layoutViewField_colCategorie1,
            this.layoutViewField_colReference1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // Group1
            // 
            this.Group1.CustomizationFormText = "Group1";
            this.Group1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colNom1,
            this.layoutViewField_colQuantiteMin1});
            this.Group1.Location = new System.Drawing.Point(153, 0);
            this.Group1.Name = "Group1";
            this.Group1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.Group1.Size = new System.Drawing.Size(344, 139);
            this.Group1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Group1.Text = "Group1";
            // 
            // Bdc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMain);
            this.Name = "Bdc2";
            this.Size = new System.Drawing.Size(962, 508);
            this.Load += new System.EventHandler(this.Bdc2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuantiteMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFournisseur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCategorie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRemarque1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReference1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl gridControlOrder;
        private XtraGrid.Views.Grid.GridView gridViewOrder;
        private XtraGrid.GridControl gridControlOrderLine;
        private XtraGrid.Views.Grid.GridView gridViewOrderLine;
        private XtraEditors.SplitContainerControl splitMain;
        private XtraEditors.SplitContainerControl splitContainerControl1;
        private XtraGrid.GridControl gridControlProduct;
        private XtraGrid.Views.Layout.LayoutView layoutView1;
        private XtraGrid.Columns.LayoutViewColumn colId;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId1;
        private XtraGrid.Columns.LayoutViewColumn colQuantiteMin;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colQuantiteMin1;
        private XtraGrid.Columns.LayoutViewColumn colPhoto;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhoto1;
        private XtraGrid.Columns.LayoutViewColumn colFournisseur;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFournisseur1;
        private XtraGrid.Columns.LayoutViewColumn colCategorie;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCategorie1;
        private XtraGrid.Columns.LayoutViewColumn colRemarque;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colRemarque1;
        private XtraGrid.Columns.LayoutViewColumn colReference;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colReference1;
        private XtraGrid.Columns.LayoutViewColumn colNom;
        private XtraGrid.Views.Layout.LayoutViewField layoutViewField_colNom1;
        private XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private XtraLayout.LayoutControlGroup Group1;
    }
}
