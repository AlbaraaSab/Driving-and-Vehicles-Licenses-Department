namespace DVLD.Tests.Test_Types
{
    partial class ucTestTypes
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
            this.dgvTestTypes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmEditTestType = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTestTypes.Location = new System.Drawing.Point(0, 0);
            this.dgvTestTypes.MainView = this.gridView1;
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.Size = new System.Drawing.Size(602, 419);
            this.dgvTestTypes.TabIndex = 0;
            this.dgvTestTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvTestTypes;
            this.gridView1.Name = "gridView1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmEditTestType});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // cmEditTestType
            // 
            this.cmEditTestType.Image = global::DVLD.Properties.Resources.edit_32;
            this.cmEditTestType.Name = "cmEditTestType";
            this.cmEditTestType.Size = new System.Drawing.Size(180, 22);
            this.cmEditTestType.Text = "Edit Test Type";
            this.cmEditTestType.Click += new System.EventHandler(this.cmEditTestType_Click);
            // 
            // ucTestTypes
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTestTypes);
            this.Name = "ucTestTypes";
            this.Size = new System.Drawing.Size(602, 419);
            this.Load += new System.EventHandler(this.ucTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvTestTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmEditTestType;
    }
}
