using vente_embarque.presenter.Secteur;

namespace DevExpress.MailClient.Win.Modules
{
    partial class Sector : ISecteurView
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlSecteur = new DevExpress.XtraGrid.GridControl();
            this.gridViewSecteur = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlSecteur);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1226, 621);
            this.splitContainerControl1.SplitterPosition = 367;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlSecteur
            // 
            this.gridControlSecteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSecteur.Location = new System.Drawing.Point(0, 0);
            this.gridControlSecteur.MainView = this.gridViewSecteur;
            this.gridControlSecteur.Name = "gridControlSecteur";
            this.gridControlSecteur.Size = new System.Drawing.Size(1226, 367);
            this.gridControlSecteur.TabIndex = 0;
            this.gridControlSecteur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSecteur});
            this.gridControlSecteur.DoubleClick += new System.EventHandler(this.gridViewProduct_DoubleClick);
            // 
            // gridViewSecteur
            // 
            this.gridViewSecteur.GridControl = this.gridControlSecteur;
            this.gridViewSecteur.Name = "gridViewSecteur";
            this.gridViewSecteur.OptionsBehavior.Editable = false;
            this.gridViewSecteur.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            // 
            // Sector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Sector";
            this.Size = new System.Drawing.Size(1226, 621);
            this.Load += new System.EventHandler(this.Sector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSecteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.SplitContainerControl splitContainerControl1;
        private XtraGrid.GridControl gridControlSecteur;
        private XtraGrid.Views.Grid.GridView gridViewSecteur;

    }
}
