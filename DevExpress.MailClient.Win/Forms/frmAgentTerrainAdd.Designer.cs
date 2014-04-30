namespace DevExpress.MailClient.Win.Forms
{
    partial class frmAgentTerrainAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgentTerrainAdd));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bbiNouveau = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSauvegarder = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSauvegarderFermer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEffacer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFermer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEditNom = new DevExpress.XtraEditors.TextEdit();
            this.labelStock = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiNouveau,
            this.bbiSauvegarder,
            this.bbiSauvegarderFermer,
            this.bbiEffacer,
            this.bbiFermer});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(617, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // bbiNouveau
            // 
            this.bbiNouveau.Caption = "Nouveau";
            this.bbiNouveau.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiNouveau.Glyph")));
            this.bbiNouveau.Id = 1;
            this.bbiNouveau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiNouveau.LargeGlyph")));
            this.bbiNouveau.Name = "bbiNouveau";
            this.bbiNouveau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNouveau_ItemClick);
            // 
            // bbiSauvegarder
            // 
            this.bbiSauvegarder.Caption = "Sauvegarder";
            this.bbiSauvegarder.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarder.Glyph")));
            this.bbiSauvegarder.Id = 2;
            this.bbiSauvegarder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarder.LargeGlyph")));
            this.bbiSauvegarder.Name = "bbiSauvegarder";
            this.bbiSauvegarder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSauvegarder_ItemClick);
            // 
            // bbiSauvegarderFermer
            // 
            this.bbiSauvegarderFermer.Caption = "Sauvegarder et Fermer";
            this.bbiSauvegarderFermer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarderFermer.Glyph")));
            this.bbiSauvegarderFermer.Id = 4;
            this.bbiSauvegarderFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarderFermer.LargeGlyph")));
            this.bbiSauvegarderFermer.Name = "bbiSauvegarderFermer";
            this.bbiSauvegarderFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSauvegarderFermer_ItemClick);
            // 
            // bbiEffacer
            // 
            this.bbiEffacer.Caption = "Effacer";
            this.bbiEffacer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiEffacer.Glyph")));
            this.bbiEffacer.Id = 5;
            this.bbiEffacer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiEffacer.LargeGlyph")));
            this.bbiEffacer.Name = "bbiEffacer";
            this.bbiEffacer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEffacer_ItemClick);
            // 
            // bbiFermer
            // 
            this.bbiFermer.Caption = "Fermer";
            this.bbiFermer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFermer.Glyph")));
            this.bbiFermer.Id = 6;
            this.bbiFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFermer.LargeGlyph")));
            this.bbiFermer.Name = "bbiFermer";
            this.bbiFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFermer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNouveau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Nouveau";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSauvegarder);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSauvegarderFermer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Sauvegarder";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiEffacer);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Reinitialiser";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiFermer);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Fermer";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 303);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(617, 31);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditNom);
            this.groupControl1.Controls.Add(this.labelStock);
            this.groupControl1.Location = new System.Drawing.Point(0, 171);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(617, 96);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Information sur l\'agent de terrain";
            // 
            // textEditNom
            // 
            this.textEditNom.Location = new System.Drawing.Point(77, 44);
            this.textEditNom.MenuManager = this.ribbon;
            this.textEditNom.Name = "textEditNom";
            this.textEditNom.Size = new System.Drawing.Size(140, 20);
            this.textEditNom.TabIndex = 19;
            // 
            // labelStock
            // 
            this.labelStock.Location = new System.Drawing.Point(22, 47);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(21, 13);
            this.labelStock.TabIndex = 4;
            this.labelStock.Text = "Nom";
            // 
            // frmAgentTerrainAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 334);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgentTerrainAdd";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ajouter un agent terrain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.BarButtonItem bbiNouveau;
        private XtraBars.BarButtonItem bbiSauvegarder;
        private XtraBars.BarButtonItem bbiSauvegarderFermer;
        private XtraBars.BarButtonItem bbiEffacer;
        private XtraBars.BarButtonItem bbiFermer;
        private XtraEditors.GroupControl groupControl1;
        private XtraEditors.TextEdit textEditNom;
        private XtraEditors.LabelControl labelStock;
    }
}