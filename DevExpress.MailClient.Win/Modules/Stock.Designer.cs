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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.icEditors = new DevExpress.Utils.ImageCollection(this.components);
            this.ilColumns = new System.Windows.Forms.ImageList(this.components);
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).BeginInit();
            this.splitmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
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
            this.splitmain.SplitterPosition = 206;
            // 
            // gridControlStock
            // 
            resources.ApplyResources(this.gridControlStock, "gridControlStock");
            this.gridControlStock.MainView = this.gridView1;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlStock;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // splitContainerControl1
            // 
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlProduct);
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.SplitterPosition = 541;
            // 
            // gridControlProduct
            // 
            resources.ApplyResources(this.gridControlProduct, "gridControlProduct");
            this.gridControlProduct.MainView = this.gridView2;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlProduct;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
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
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // Mail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitmain);
            this.Name = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).EndInit();
            this.splitmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection icEditors;
        private System.Windows.Forms.ImageList ilColumns;
        private XtraGrid.GridSplitContainer gridSplitContainer1;
        private XtraEditors.SplitContainerControl splitmain;
        private XtraGrid.GridControl gridControlStock;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraEditors.SplitContainerControl splitContainerControl1;
        private XtraGrid.GridControl gridControlProduct;
        private XtraGrid.Views.Grid.GridView gridView2;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Card.CardView cardView1;
    }
}
