namespace DVLD.Licenses.Controls
{
    partial class ctrlDriverLicenses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDriverLocalLicenses = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDriverInterNationalLicenses = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInternationalLicenseInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InternationalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverLocalLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverInterNationalLicenses)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 217);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDriverLocalLicenses);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDriverLocalLicenses
            // 
            this.dgvDriverLocalLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDriverLocalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDriverLocalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvDriverLocalLicenses.MainView = this.LocalGridView;
            this.dgvDriverLocalLicenses.Name = "dgvDriverLocalLicenses";
            this.dgvDriverLocalLicenses.Size = new System.Drawing.Size(673, 185);
            this.dgvDriverLocalLicenses.TabIndex = 0;
            this.dgvDriverLocalLicenses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LocalGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // LocalGridView
            // 
            this.LocalGridView.GridControl = this.dgvDriverLocalLicenses;
            this.LocalGridView.Name = "LocalGridView";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDriverInterNationalLicenses);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDriverInterNationalLicenses
            // 
            this.dgvDriverInterNationalLicenses.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvDriverInterNationalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDriverInterNationalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvDriverInterNationalLicenses.MainView = this.InternationalGridView;
            this.dgvDriverInterNationalLicenses.Name = "dgvDriverInterNationalLicenses";
            this.dgvDriverInterNationalLicenses.Size = new System.Drawing.Size(673, 185);
            this.dgvDriverInterNationalLicenses.TabIndex = 0;
            this.dgvDriverInterNationalLicenses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InternationalGridView});
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInternationalLicenseInfoToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(170, 26);
            // 
            // showInternationalLicenseInfoToolStripMenuItem1
            // 
            this.showInternationalLicenseInfoToolStripMenuItem1.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showInternationalLicenseInfoToolStripMenuItem1.Name = "showInternationalLicenseInfoToolStripMenuItem1";
            this.showInternationalLicenseInfoToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.showInternationalLicenseInfoToolStripMenuItem1.Text = "Show License Info";
            this.showInternationalLicenseInfoToolStripMenuItem1.Click += new System.EventHandler(this.showInternationalLicenseInfoToolStripMenuItem1_Click);
            // 
            // InternationalGridView
            // 
            this.InternationalGridView.GridControl = this.dgvDriverInterNationalLicenses;
            this.InternationalGridView.Name = "InternationalGridView";
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(693, 237);
            this.Load += new System.EventHandler(this.ctrlDriverLicenses_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverLocalLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocalGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverInterNationalLicenses)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InternationalGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl dgvDriverLocalLicenses;
        private DevExpress.XtraGrid.Views.Grid.GridView LocalGridView;
        private DevExpress.XtraGrid.GridControl dgvDriverInterNationalLicenses;
        private DevExpress.XtraGrid.Views.Grid.GridView InternationalGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicenseInfoToolStripMenuItem1;
    }
}
