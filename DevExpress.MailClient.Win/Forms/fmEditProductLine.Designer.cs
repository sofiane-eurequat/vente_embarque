using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Forms
{
    partial class FrmEditProductLine : IEditProductLineView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditProductLine));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSauvegarderFermer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNouveau = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFermer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEfaccer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxProduit = new System.Windows.Forms.ComboBox();
            this.textEditQuantité = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxStock = new System.Windows.Forms.ComboBox();
            this.labelQuantité = new DevExpress.XtraEditors.LabelControl();
            this.labelProduit = new DevExpress.XtraEditors.LabelControl();
            this.labelStock = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantité.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiSauvegarderFermer,
            this.bbiNouveau,
            this.bbiFermer,
            this.bbiEfaccer});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(617, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbiSauvegarderFermer
            // 
            this.bbiSauvegarderFermer.Caption = "Sauvegarder";
            this.bbiSauvegarderFermer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarderFermer.Glyph")));
            this.bbiSauvegarderFermer.Id = 1;
            this.bbiSauvegarderFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSauvegarderFermer.LargeGlyph")));
            this.bbiSauvegarderFermer.Name = "bbiSauvegarderFermer";
            this.bbiSauvegarderFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSauvegarderFermer_ItemClick);
            // 
            // bbiNouveau
            // 
            this.bbiNouveau.Caption = "Nouveau";
            this.bbiNouveau.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiNouveau.Glyph")));
            this.bbiNouveau.Id = 3;
            this.bbiNouveau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiNouveau.LargeGlyph")));
            this.bbiNouveau.Name = "bbiNouveau";
            this.bbiNouveau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNouveau_ItemClick);
            // 
            // bbiFermer
            // 
            this.bbiFermer.Caption = "Fermer";
            this.bbiFermer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFermer.Glyph")));
            this.bbiFermer.Id = 5;
            this.bbiFermer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFermer.LargeGlyph")));
            this.bbiFermer.Name = "bbiFermer";
            this.bbiFermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFermer_ItemClick);
            // 
            // bbiEfaccer
            // 
            this.bbiEfaccer.Caption = "Effacer";
            this.bbiEfaccer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiEfaccer.Glyph")));
            this.bbiEfaccer.Id = 6;
            this.bbiEfaccer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiEfaccer.LargeGlyph")));
            this.bbiEfaccer.Name = "bbiEfaccer";
            this.bbiEfaccer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEfaccer_ItemClick);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNouveau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Nouveau";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSauvegarderFermer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Sauvegarder";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiEfaccer);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Reinitialiser";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiFermer);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Fermer";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 339);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(617, 31);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxProduit);
            this.groupControl1.Controls.Add(this.textEditQuantité);
            this.groupControl1.Controls.Add(this.comboBoxStock);
            this.groupControl1.Controls.Add(this.labelQuantité);
            this.groupControl1.Controls.Add(this.labelProduit);
            this.groupControl1.Controls.Add(this.labelStock);
            this.groupControl1.Location = new System.Drawing.Point(0, 150);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(617, 154);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Information sur la ligne de stock";
            // 
            // comboBoxProduit
            // 
            this.comboBoxProduit.DisplayMember = "id";
            this.comboBoxProduit.FormattingEnabled = true;
            this.comboBoxProduit.Location = new System.Drawing.Point(392, 44);
            this.comboBoxProduit.Name = "comboBoxProduit";
            this.comboBoxProduit.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProduit.TabIndex = 20;
            this.comboBoxProduit.ValueMember = "id";
            this.comboBoxProduit.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduit_SelectedIndexChanged);
            // 
            // textEditQuantité
            // 
            this.textEditQuantité.Location = new System.Drawing.Point(69, 100);
            this.textEditQuantité.MenuManager = this.ribbon;
            this.textEditQuantité.Name = "textEditQuantité";
            this.textEditQuantité.Size = new System.Drawing.Size(217, 20);
            this.textEditQuantité.TabIndex = 19;
            this.textEditQuantité.EditValueChanged += new System.EventHandler(this.textEditQuantité_EditValueChanged);
            // 
            // comboBoxStock
            // 
            this.comboBoxStock.DisplayMember = "id";
            this.comboBoxStock.FormattingEnabled = true;
            this.comboBoxStock.Location = new System.Drawing.Point(69, 44);
            this.comboBoxStock.Name = "comboBoxStock";
            this.comboBoxStock.Size = new System.Drawing.Size(217, 21);
            this.comboBoxStock.TabIndex = 17;
            this.comboBoxStock.ValueMember = "id";
            this.comboBoxStock.SelectedValueChanged += new System.EventHandler(this.comboBoxStock_SelectedValueChanged);
            // 
            // labelQuantité
            // 
            this.labelQuantité.Location = new System.Drawing.Point(12, 103);
            this.labelQuantité.Name = "labelQuantité";
            this.labelQuantité.Size = new System.Drawing.Size(42, 13);
            this.labelQuantité.TabIndex = 7;
            this.labelQuantité.Text = "Quantité";
            // 
            // labelProduit
            // 
            this.labelProduit.Location = new System.Drawing.Point(332, 47);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(34, 13);
            this.labelProduit.TabIndex = 5;
            this.labelProduit.Text = "Produit";
            // 
            // labelStock
            // 
            this.labelStock.Location = new System.Drawing.Point(12, 47);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(26, 13);
            this.labelStock.TabIndex = 4;
            this.labelStock.Text = "Stock";
            // 
            // FrmEditProductLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 370);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmEditProductLine";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ligne de stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditProductLine_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantité.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private XtraBars.BarButtonItem bbiSauvegarderFermer;
        private XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBoxStock;
        private XtraEditors.LabelControl labelQuantité;
        private XtraEditors.LabelControl labelProduit;
        private XtraEditors.LabelControl labelStock;
        private XtraEditors.TextEdit textEditQuantité;
        private XtraBars.BarButtonItem bbiNouveau;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.BarButtonItem bbiFermer;
        private XtraBars.BarButtonItem bbiEfaccer;
        private System.Windows.Forms.ComboBox comboBoxProduit;
    }
}