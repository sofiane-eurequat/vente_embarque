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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
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
          //  this.gridControlOrder.Click += new System.EventHandler(this.gridControlOrder_Click_1);
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
            this.gridControlOrderLine.Size = new System.Drawing.Size(962, 301);
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlOrder);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlOrderLine);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(962, 508);
            this.splitContainerControl1.SplitterPosition = 202;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Bdc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Bdc2";
            this.Size = new System.Drawing.Size(962, 508);
            this.Load += new System.EventHandler(this.Bdc2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl gridControlOrder;
        private XtraGrid.Views.Grid.GridView gridViewOrder;
        private XtraGrid.GridControl gridControlOrderLine;
        private XtraGrid.Views.Grid.GridView gridViewOrderLine;
        private XtraEditors.SplitContainerControl splitContainerControl1;
    }
}
