namespace DevExpress.MailClient.Win.Controls {
    partial class ucContacts {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContacts));
            this.ceList = new DevExpress.XtraEditors.CheckEdit();
            this.ceAlphabetical = new DevExpress.XtraEditors.CheckEdit();
            this.ceState = new DevExpress.XtraEditors.CheckEdit();
            this.ceCards = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ceList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAlphabetical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCards.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ceList
            // 
            resources.ApplyResources(this.ceList, "ceList");
            this.ceList.Name = "ceList";
            this.ceList.Properties.AutoWidth = true;
            this.ceList.Properties.Caption = resources.GetString("ceList.Properties.Caption");
            this.ceList.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceList.Properties.RadioGroupIndex = 0;
            this.ceList.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // ceAlphabetical
            // 
            resources.ApplyResources(this.ceAlphabetical, "ceAlphabetical");
            this.ceAlphabetical.Name = "ceAlphabetical";
            this.ceAlphabetical.Properties.AutoWidth = true;
            this.ceAlphabetical.Properties.Caption = resources.GetString("ceAlphabetical.Properties.Caption");
            this.ceAlphabetical.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceAlphabetical.Properties.RadioGroupIndex = 0;
            this.ceAlphabetical.TabStop = false;
            this.ceAlphabetical.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // ceState
            // 
            resources.ApplyResources(this.ceState, "ceState");
            this.ceState.Name = "ceState";
            this.ceState.Properties.AutoWidth = true;
            this.ceState.Properties.Caption = resources.GetString("ceState.Properties.Caption");
            this.ceState.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceState.Properties.RadioGroupIndex = 0;
            this.ceState.TabStop = false;
            this.ceState.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // ceCards
            // 
            resources.ApplyResources(this.ceCards, "ceCards");
            this.ceCards.Name = "ceCards";
            this.ceCards.Properties.AutoWidth = true;
            this.ceCards.Properties.Caption = resources.GetString("ceCards.Properties.Caption");
            this.ceCards.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceCards.Properties.RadioGroupIndex = 0;
            this.ceCards.TabStop = false;
            this.ceCards.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.LineVisible = true;
            this.labelControl1.Name = "labelControl1";
            // 
            // ucContacts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ceCards);
            this.Controls.Add(this.ceState);
            this.Controls.Add(this.ceAlphabetical);
            this.Controls.Add(this.ceList);
            this.Name = "ucContacts";
            this.Resize += new System.EventHandler(this.ucContacts_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ceList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAlphabetical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCards.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit ceList;
        private DevExpress.XtraEditors.CheckEdit ceAlphabetical;
        private DevExpress.XtraEditors.CheckEdit ceState;
        private DevExpress.XtraEditors.CheckEdit ceCards;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
