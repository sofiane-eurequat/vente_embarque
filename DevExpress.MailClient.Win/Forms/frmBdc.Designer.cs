namespace DevExpress.MailClient.Win.Forms
{
    partial class frmBdc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBdc));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNouveau = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSauvegarder = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFermer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEfaccer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSauvegarderFermer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxPriorite = new System.Windows.Forms.ComboBox();
            this.labelPriorite = new DevExpress.XtraEditors.LabelControl();
            this.memoEditAdresssLivraion = new DevExpress.XtraEditors.MemoEdit();
            this.dateEditLivraison = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.labelDateLivraison = new DevExpress.XtraEditors.LabelControl();
            this.labelAdresseLivraison = new DevExpress.XtraEditors.LabelControl();
            this.labelClient = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.GCOrderLine = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrderLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bbiAddOrderLine = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSuppOrderLine = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAdresssLivraion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLivraison.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLivraison.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCOrderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiNouveau,
            this.barButtonItem1,
            this.bbiSauvegarder,
            this.bbiFermer,
            this.bbiEfaccer,
            this.bbiSauvegarderFermer});
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.barButtonItem1);
            // 
            // bbiNouveau
            // 
            resources.ApplyResources(this.bbiNouveau, "bbiNouveau");
            this.bbiNouveau.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiNouveau.Glyph")));
            this.bbiNouveau.Id = 1;
            this.bbiNouveau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiNouveau.LargeGlyph")));
            this.bbiNouveau.Name = "bbiNouveau";
            this.bbiNouveau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNouveau_ItemClick);
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbiSauvegarder
            // 
            resources.ApplyResources(this.bbiSauvegarder, "bbiSauvegarder");
            this.bbiSauvegarder.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarder.Glyph")));
            this.bbiSauvegarder.Id = 3;
            this.bbiSauvegarder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarder.LargeGlyph")));
            this.bbiSauvegarder.Name = "bbiSauvegarder";
            this.bbiSauvegarder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSauvegarder_ItemClick);
            // 
            // bbiFermer
            // 
            resources.ApplyResources(this.bbiFermer, "bbiFermer");
            this.bbiFermer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFermer.Glyph")));
            this.bbiFermer.Id = 4;
            this.bbiFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFermer.LargeGlyph")));
            this.bbiFermer.Name = "bbiFermer";
            this.bbiFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFermer_ItemClick);
            // 
            // bbiEfaccer
            // 
            resources.ApplyResources(this.bbiEfaccer, "bbiEfaccer");
            this.bbiEfaccer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiEfaccer.Glyph")));
            this.bbiEfaccer.Id = 5;
            this.bbiEfaccer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiEfaccer.LargeGlyph")));
            this.bbiEfaccer.Name = "bbiEfaccer";
            this.bbiEfaccer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEfaccer_ItemClick);
            // 
            // bbiSauvegarderFermer
            // 
            resources.ApplyResources(this.bbiSauvegarderFermer, "bbiSauvegarderFermer");
            this.bbiSauvegarderFermer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarderFermer.Glyph")));
            this.bbiSauvegarderFermer.Id = 6;
            this.bbiSauvegarderFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarderFermer.LargeGlyph")));
            this.bbiSauvegarderFermer.Name = "bbiSauvegarderFermer";
            this.bbiSauvegarderFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSauvegarderFermer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNouveau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSauvegarder);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSauvegarderFermer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiEfaccer);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiFermer);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup4, "ribbonPageGroup4");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxPriorite);
            this.groupControl1.Controls.Add(this.labelPriorite);
            this.groupControl1.Controls.Add(this.memoEditAdresssLivraion);
            this.groupControl1.Controls.Add(this.dateEditLivraison);
            this.groupControl1.Controls.Add(this.comboBoxClients);
            this.groupControl1.Controls.Add(this.labelDateLivraison);
            this.groupControl1.Controls.Add(this.labelAdresseLivraison);
            this.groupControl1.Controls.Add(this.labelClient);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // comboBoxPriorite
            // 
            this.comboBoxPriorite.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxPriorite, "comboBoxPriorite");
            this.comboBoxPriorite.Name = "comboBoxPriorite";
            // 
            // labelPriorite
            // 
            this.labelPriorite.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelPriorite.Appearance.Font")));
            resources.ApplyResources(this.labelPriorite, "labelPriorite");
            this.labelPriorite.Name = "labelPriorite";
            // 
            // memoEditAdresssLivraion
            // 
            resources.ApplyResources(this.memoEditAdresssLivraion, "memoEditAdresssLivraion");
            this.memoEditAdresssLivraion.MenuManager = this.ribbon;
            this.memoEditAdresssLivraion.Name = "memoEditAdresssLivraion";
            this.memoEditAdresssLivraion.UseOptimizedRendering = true;
            // 
            // dateEditLivraison
            // 
            resources.ApplyResources(this.dateEditLivraison, "dateEditLivraison");
            this.dateEditLivraison.MenuManager = this.ribbon;
            this.dateEditLivraison.Name = "dateEditLivraison";
            this.dateEditLivraison.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateEditLivraison.Properties.Buttons"))))});
            this.dateEditLivraison.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateEditLivraison.Properties.CalendarTimeProperties.Buttons"))))});
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.DisplayMember = "id";
            this.comboBoxClients.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxClients, "comboBoxClients");
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.ValueMember = "id";
            // 
            // labelDateLivraison
            // 
            this.labelDateLivraison.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelDateLivraison.Appearance.Font")));
            resources.ApplyResources(this.labelDateLivraison, "labelDateLivraison");
            this.labelDateLivraison.Name = "labelDateLivraison";
            // 
            // labelAdresseLivraison
            // 
            this.labelAdresseLivraison.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelAdresseLivraison.Appearance.Font")));
            resources.ApplyResources(this.labelAdresseLivraison, "labelAdresseLivraison");
            this.labelAdresseLivraison.Name = "labelAdresseLivraison";
            // 
            // labelClient
            // 
            this.labelClient.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelClient.Appearance.Font")));
            resources.ApplyResources(this.labelClient, "labelClient");
            this.labelClient.Name = "labelClient";
            // 
            // xtraTabControl1
            // 
            resources.ApplyResources(this.xtraTabControl1, "xtraTabControl1");
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.GCOrderLine);
            this.xtraTabPage1.Controls.Add(this.standaloneBarDockControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            resources.ApplyResources(this.xtraTabPage1, "xtraTabPage1");
            // 
            // GCOrderLine
            // 
            resources.ApplyResources(this.GCOrderLine, "GCOrderLine");
            this.GCOrderLine.MainView = this.gridViewOrderLine;
            this.GCOrderLine.MenuManager = this.ribbon;
            this.GCOrderLine.Name = "GCOrderLine";
            this.GCOrderLine.UseEmbeddedNavigator = true;
            this.GCOrderLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderLine});
            // 
            // gridViewOrderLine
            // 
            this.gridViewOrderLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct,
            this.colQuantity});
            this.gridViewOrderLine.GridControl = this.GCOrderLine;
            this.gridViewOrderLine.Name = "gridViewOrderLine";
            this.gridViewOrderLine.OptionsView.ShowGroupPanel = false;
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            resources.ApplyResources(this.colProduct, "colProduct");
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            resources.ApplyResources(this.colQuantity, "colQuantity");
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            resources.ApplyResources(this.standaloneBarDockControl1, "standaloneBarDockControl1");
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.bbiAddOrderLine,
            this.bbiSuppOrderLine});
            this.barManager1.MaxItemId = 4;
            // 
            // bar4
            // 
            this.bar4.BarName = "Editer";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar4.FloatLocation = new System.Drawing.Point(102, 416);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddOrderLine),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppOrderLine)});
            this.bar4.Offset = 1;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.StandaloneBarDockControl = this.standaloneBarDockControl1;
            resources.ApplyResources(this.bar4, "bar4");
            // 
            // bbiAddOrderLine
            // 
            resources.ApplyResources(this.bbiAddOrderLine, "bbiAddOrderLine");
            this.bbiAddOrderLine.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiAddOrderLine.Glyph")));
            this.bbiAddOrderLine.Id = 2;
            this.bbiAddOrderLine.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiAddOrderLine.LargeGlyph")));
            this.bbiAddOrderLine.Name = "bbiAddOrderLine";
            this.bbiAddOrderLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddOrderLine_ItemClick);
            // 
            // bbiSuppOrderLine
            // 
            resources.ApplyResources(this.bbiSuppOrderLine, "bbiSuppOrderLine");
            this.bbiSuppOrderLine.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSuppOrderLine.Glyph")));
            this.bbiSuppOrderLine.Id = 3;
            this.bbiSuppOrderLine.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSuppOrderLine.LargeGlyph")));
            this.bbiSuppOrderLine.Name = "bbiSuppOrderLine";
            this.bbiSuppOrderLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSuppOrderLine_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmBdc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmBdc";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.frmBdc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAdresssLivraion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLivraison.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLivraison.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCOrderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private XtraBars.BarButtonItem bbiNouveau;
        private XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private XtraEditors.LabelControl labelDateLivraison;
        private XtraEditors.LabelControl labelAdresseLivraison;
        private XtraEditors.LabelControl labelClient;
        private XtraTab.XtraTabControl xtraTabControl1;
        private XtraTab.XtraTabPage xtraTabPage1;
        private XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private XtraBars.BarManager barManager1;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.Bar bar4;
        private XtraBars.BarButtonItem barButtonItem2;
        private XtraBars.BarButtonItem bbiAddOrderLine;
        private XtraBars.BarButtonItem bbiSuppOrderLine;
        private XtraGrid.GridControl GCOrderLine;
        private XtraGrid.Views.Grid.GridView gridViewOrderLine;
        private XtraEditors.DateEdit dateEditLivraison;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.BarButtonItem bbiSauvegarder;
        private XtraEditors.MemoEdit memoEditAdresssLivraion;
        private XtraGrid.Columns.GridColumn colProduct;
        private XtraGrid.Columns.GridColumn colQuantity;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.BarButtonItem bbiFermer;
        private XtraBars.BarButtonItem bbiEfaccer;
        private XtraBars.BarButtonItem bbiSauvegarderFermer;
        private XtraEditors.LabelControl labelPriorite;
        private System.Windows.Forms.ComboBox comboBoxPriorite;
    }
}