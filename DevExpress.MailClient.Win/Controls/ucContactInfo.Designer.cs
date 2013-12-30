namespace DevExpress.MailClient.Win.Controls {
    partial class ucContactInfo {
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lcInfo = new DevExpress.XtraEditors.LabelControl();
            this.pePhoto = new DevExpress.MailClient.Win.PictureEditSimpleZoom();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPhoto = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomizationMenu = false;
            this.lcMain.Controls.Add(this.lcInfo);
            this.lcMain.Controls.Add(this.pePhoto);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(669, 200, 450, 350);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(227, 397);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lcInfo
            // 
            this.lcInfo.AllowHtmlString = true;
            this.lcInfo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lcInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lcInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lcInfo.Location = new System.Drawing.Point(2, 199);
            this.lcInfo.Name = "lcInfo";
            this.lcInfo.Size = new System.Drawing.Size(223, 185);
            this.lcInfo.StyleController = this.lcMain;
            this.lcInfo.TabIndex = 5;
            // 
            // pePhoto
            // 
            this.pePhoto.Location = new System.Drawing.Point(0, 0);
            this.pePhoto.Name = "pePhoto";
            this.pePhoto.Properties.AllowFocused = false;
            this.pePhoto.Properties.NullText = " ";
            this.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pePhoto.Properties.ReadOnly = true;
            this.pePhoto.Properties.ShowMenu = false;
            this.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pePhoto.Size = new System.Drawing.Size(227, 197);
            this.pePhoto.StyleController = this.lcMain;
            this.pePhoto.TabIndex = 4;
            this.pePhoto.Resize += new System.EventHandler(this.pePhoto_Resize);
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPhoto,
            this.lciInfo,
            this.emptySpaceItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(227, 397);
            this.lcgMain.Text = "Root";
            this.lcgMain.TextVisible = false;
            // 
            // lciPhoto
            // 
            this.lciPhoto.Control = this.pePhoto;
            this.lciPhoto.CustomizationFormText = "lciPhoto";
            this.lciPhoto.Location = new System.Drawing.Point(0, 0);
            this.lciPhoto.Name = "lciPhoto";
            this.lciPhoto.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciPhoto.Size = new System.Drawing.Size(227, 197);
            this.lciPhoto.Text = "lciPhoto";
            this.lciPhoto.TextSize = new System.Drawing.Size(0, 0);
            this.lciPhoto.TextToControlDistance = 0;
            this.lciPhoto.TextVisible = false;
            // 
            // lciInfo
            // 
            this.lciInfo.Control = this.lcInfo;
            this.lciInfo.CustomizationFormText = "lciInfo";
            this.lciInfo.Location = new System.Drawing.Point(0, 197);
            this.lciInfo.Name = "lciInfo";
            this.lciInfo.Size = new System.Drawing.Size(227, 189);
            this.lciInfo.Text = "lciInfo";
            this.lciInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciInfo.TextToControlDistance = 0;
            this.lciInfo.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 386);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(227, 11);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "ucContactInfo";
            this.Size = new System.Drawing.Size(227, 397);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.LabelControl lcInfo;
        private PictureEditSimpleZoom pePhoto;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciPhoto;
        private DevExpress.XtraLayout.LayoutControlItem lciInfo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
