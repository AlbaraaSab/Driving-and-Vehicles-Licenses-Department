namespace DVLD.Applications.Application_Types
{
    partial class ucApplicationTypes
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
            this.components = new System.ComponentModel.Container();
            this.dgvApplicationTypes = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplicationTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(0, 0);
            this.dgvApplicationTypes.MainView = this.gridView1;
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.Size = new System.Drawing.Size(696, 438);
            this.dgvApplicationTypes.TabIndex = 0;
            this.dgvApplicationTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmEditApplicationType});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 26);
            // 
            // cmEditApplicationType
            // 
            this.cmEditApplicationType.Image = global::DVLD.Properties.Resources.edit_32;
            this.cmEditApplicationType.Name = "cmEditApplicationType";
            this.cmEditApplicationType.Size = new System.Drawing.Size(185, 22);
            this.cmEditApplicationType.Text = "Edit Application Type";
            this.cmEditApplicationType.Click += new System.EventHandler(this.cmEditApplicationType_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvApplicationTypes;
            this.gridView1.Name = "gridView1";
            // 
            // ucApplicationTypes
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvApplicationTypes);
            this.Name = "ucApplicationTypes";
            this.Size = new System.Drawing.Size(696, 438);
            this.Load += new System.EventHandler(this.ucApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvApplicationTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmEditApplicationType;
    }
}
