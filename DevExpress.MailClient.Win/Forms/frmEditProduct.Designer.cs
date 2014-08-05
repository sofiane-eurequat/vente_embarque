using vente_embarque.presenter.Stok;

namespace DevExpress.MailClient.Win.Forms{
    partial class FrmEditProduct : IEditProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditProduct));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveClsoe = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClear = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.GCInfoGeneral = new DevExpress.XtraEditors.GroupControl();
            this.labelNameFournisseur = new DevExpress.XtraEditors.LabelControl();
            this.textEditQuantité = new DevExpress.XtraEditors.TextEdit();
            this.dateEditEntree = new DevExpress.XtraEditors.DateEdit();
            this.labelQuantity = new DevExpress.XtraEditors.LabelControl();
            this.labelDateEntree = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxTypeGestion = new System.Windows.Forms.ComboBox();
            this.labelTypeGestion = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.textEditNameProduct = new DevExpress.XtraEditors.TextEdit();
            this.labelNameProduit = new DevExpress.XtraEditors.LabelControl();
            this.labelMarque = new DevExpress.XtraEditors.LabelControl();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.comboBoxFournisseur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCInfoGeneral)).BeginInit();
            this.GCInfoGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantité.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEntree.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEntree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiNew,
            this.bbiSave,
            this.bbiSaveClsoe,
            this.bbiClear,
            this.bbiClose});
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu
            // 
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Ribbon = this.ribbon;
            // 
            // bbiNew
            // 
            resources.ApplyResources(this.bbiNew, "bbiNew");
            this.bbiNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiNew.Glyph")));
            this.bbiNew.Id = 1;
            this.bbiNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiNew.LargeGlyph")));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiSave
            // 
            resources.ApplyResources(this.bbiSave, "bbiSave");
            this.bbiSave.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.Glyph")));
            this.bbiSave.Id = 2;
            this.bbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.LargeGlyph")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveClsoe
            // 
            resources.ApplyResources(this.bbiSaveClsoe, "bbiSaveClsoe");
            this.bbiSaveClsoe.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSaveClsoe.Glyph")));
            this.bbiSaveClsoe.Id = 3;
            this.bbiSaveClsoe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSaveClsoe.LargeGlyph")));
            this.bbiSaveClsoe.Name = "bbiSaveClsoe";
            this.bbiSaveClsoe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveClsoe_ItemClick);
            // 
            // bbiClear
            // 
            resources.ApplyResources(this.bbiClear, "bbiClear");
            this.bbiClear.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiClear.Glyph")));
            this.bbiClear.Id = 4;
            this.bbiClear.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiClear.LargeGlyph")));
            this.bbiClear.Name = "bbiClear";
            this.bbiClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClear_ItemClick);
            // 
            // bbiClose
            // 
            resources.ApplyResources(this.bbiClose, "bbiClose");
            this.bbiClose.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiClose.Glyph")));
            this.bbiClose.Id = 5;
            this.bbiClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiClose.LargeGlyph")));
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup10.ItemLinks.Add(this.bbiSaveClsoe);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup10, "ribbonPageGroup10");
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.AllowTextClipping = false;
            this.ribbonPageGroup11.ItemLinks.Add(this.bbiClear);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup11, "ribbonPageGroup11");
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.AllowTextClipping = false;
            this.ribbonPageGroup12.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup12, "ribbonPageGroup12");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // GCInfoGeneral
            // 
            this.GCInfoGeneral.Controls.Add(this.comboBoxFournisseur);
            this.GCInfoGeneral.Controls.Add(this.labelNameFournisseur);
            this.GCInfoGeneral.Controls.Add(this.textEditQuantité);
            this.GCInfoGeneral.Controls.Add(this.dateEditEntree);
            this.GCInfoGeneral.Controls.Add(this.labelQuantity);
            this.GCInfoGeneral.Controls.Add(this.labelDateEntree);
            this.GCInfoGeneral.Controls.Add(this.comboBoxTypeGestion);
            this.GCInfoGeneral.Controls.Add(this.labelTypeGestion);
            this.GCInfoGeneral.Controls.Add(this.comboBoxCategory);
            this.GCInfoGeneral.Controls.Add(this.labelCategory);
            this.GCInfoGeneral.Controls.Add(this.comboBoxMarque);
            this.GCInfoGeneral.Controls.Add(this.textEditNameProduct);
            this.GCInfoGeneral.Controls.Add(this.labelNameProduit);
            this.GCInfoGeneral.Controls.Add(this.labelMarque);
            resources.ApplyResources(this.GCInfoGeneral, "GCInfoGeneral");
            this.GCInfoGeneral.Name = "GCInfoGeneral";
            // 
            // labelNameFournisseur
            // 
            this.labelNameFournisseur.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelNameFournisseur.Appearance.Font")));
            resources.ApplyResources(this.labelNameFournisseur, "labelNameFournisseur");
            this.labelNameFournisseur.Name = "labelNameFournisseur";
            // 
            // textEditQuantité
            // 
            resources.ApplyResources(this.textEditQuantité, "textEditQuantité");
            this.textEditQuantité.MenuManager = this.ribbon;
            this.textEditQuantité.Name = "textEditQuantité";
            this.textEditQuantité.EditValueChanged += new System.EventHandler(this.textEditQuantité_EditValueChanged);
            // 
            // dateEditEntree
            // 
            resources.ApplyResources(this.dateEditEntree, "dateEditEntree");
            this.dateEditEntree.MenuManager = this.ribbon;
            this.dateEditEntree.Name = "dateEditEntree";
            this.dateEditEntree.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateEditEntree.Properties.Buttons"))))});
            this.dateEditEntree.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateEditEntree.Properties.CalendarTimeProperties.Buttons"))))});
            this.dateEditEntree.EditValueChanged += new System.EventHandler(this.dateEditEntree_EditValueChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelQuantity.Appearance.Font")));
            resources.ApplyResources(this.labelQuantity, "labelQuantity");
            this.labelQuantity.Name = "labelQuantity";
            // 
            // labelDateEntree
            // 
            this.labelDateEntree.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelDateEntree.Appearance.Font")));
            resources.ApplyResources(this.labelDateEntree, "labelDateEntree");
            this.labelDateEntree.Name = "labelDateEntree";
            // 
            // comboBoxTypeGestion
            // 
            this.comboBoxTypeGestion.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxTypeGestion, "comboBoxTypeGestion");
            this.comboBoxTypeGestion.Name = "comboBoxTypeGestion";
            this.comboBoxTypeGestion.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeGestion_SelectedIndexChanged);
            // 
            // labelTypeGestion
            // 
            this.labelTypeGestion.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelTypeGestion.Appearance.Font")));
            resources.ApplyResources(this.labelTypeGestion, "labelTypeGestion");
            this.labelTypeGestion.Name = "labelTypeGestion";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DisplayMember = "id";
            this.comboBoxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCategory, "comboBoxCategory");
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.ValueMember = "id";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelCategory.Appearance.Font")));
            resources.ApplyResources(this.labelCategory, "labelCategory");
            this.labelCategory.Name = "labelCategory";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.DisplayMember = "id";
            this.comboBoxMarque.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMarque, "comboBoxMarque");
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.ValueMember = "id";
            this.comboBoxMarque.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarque_SelectedIndexChanged);
            // 
            // textEditNameProduct
            // 
            resources.ApplyResources(this.textEditNameProduct, "textEditNameProduct");
            this.textEditNameProduct.Name = "textEditNameProduct";
            this.textEditNameProduct.EditValueChanged += new System.EventHandler(this.textEditNameProduct_EditValueChanged);
            // 
            // labelNameProduit
            // 
            this.labelNameProduit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelNameProduit.Appearance.Font")));
            this.labelNameProduit.LineVisible = true;
            resources.ApplyResources(this.labelNameProduit, "labelNameProduit");
            this.labelNameProduit.Name = "labelNameProduit";
            // 
            // labelMarque
            // 
            this.labelMarque.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelMarque.Appearance.Font")));
            resources.ApplyResources(this.labelMarque, "labelMarque");
            this.labelMarque.Name = "labelMarque";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup4, "ribbonPageGroup4");
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup5, "ribbonPageGroup5");
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup6, "ribbonPageGroup6");
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup7, "ribbonPageGroup7");
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup8, "ribbonPageGroup8");
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup9, "ribbonPageGroup9");
            // 
            // comboBoxFournisseur
            // 
            this.comboBoxFournisseur.DisplayMember = "id";
            this.comboBoxFournisseur.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxFournisseur, "comboBoxFournisseur");
            this.comboBoxFournisseur.Name = "comboBoxFournisseur";
            this.comboBoxFournisseur.ValueMember = "id";
            this.comboBoxFournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBoxFournisseur_SelectedIndexChanged);
            // 
            // FrmEditProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GCInfoGeneral);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Name = "FrmEditProduct";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditProduct_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCInfoGeneral)).EndInit();
            this.GCInfoGeneral.ResumeLayout(false);
            this.GCInfoGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantité.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEntree.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEntree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameProduct.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private XtraEditors.GroupControl GCInfoGeneral;
        private XtraEditors.LabelControl labelMarque;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private XtraBars.BarButtonItem bbiNew;
        private XtraBars.BarButtonItem bbiSave;
        private XtraBars.BarButtonItem bbiSaveClsoe;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private XtraBars.BarButtonItem bbiClear;
        private XtraBars.BarButtonItem bbiClose;
        private XtraEditors.TextEdit textEditNameProduct;
        private XtraEditors.LabelControl labelNameProduit;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private XtraEditors.LabelControl labelCategory;
        private XtraEditors.TextEdit textEditQuantité;
        private XtraEditors.LabelControl labelQuantity;
        private System.Windows.Forms.ComboBox comboBoxTypeGestion;
        private XtraEditors.LabelControl labelTypeGestion;
        private XtraEditors.DateEdit dateEditEntree;
        private XtraEditors.LabelControl labelDateEntree;
        private XtraEditors.LabelControl labelNameFournisseur;
        private System.Windows.Forms.ComboBox comboBoxFournisseur;
    }
}