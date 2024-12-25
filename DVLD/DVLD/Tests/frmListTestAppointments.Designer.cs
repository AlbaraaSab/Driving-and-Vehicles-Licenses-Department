namespace DVLD.Tests
{
    partial class frmListTestAppointments
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
            this.pbTestPicture = new System.Windows.Forms.PictureBox();
            this.lblTestType = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmEditAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.cmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookAppointment = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlLocalApplicatoinInfo1 = new DVLD.Applications.Controls.ctrlLocalApplicatoinInfo();
            this.dgvTestAppointments = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestPicture)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTestPicture
            // 
            this.pbTestPicture.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pbTestPicture.Location = new System.Drawing.Point(314, 9);
            this.pbTestPicture.Name = "pbTestPicture";
            this.pbTestPicture.Size = new System.Drawing.Size(79, 68);
            this.pbTestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestPicture.TabIndex = 0;
            this.pbTestPicture.TabStop = false;
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestType.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTestType.Location = new System.Drawing.Point(248, 88);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(210, 19);
            this.lblTestType.TabIndex = 1;
            this.lblTestType.Text = "Vision Test Appointment";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmEditAppointment,
            this.cmTakeTest});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // cmEditAppointment
            // 
            this.cmEditAppointment.Image = global::DVLD.Properties.Resources.edit_32;
            this.cmEditAppointment.Name = "cmEditAppointment";
            this.cmEditAppointment.Size = new System.Drawing.Size(120, 22);
            this.cmEditAppointment.Text = "Edit";
            this.cmEditAppointment.Click += new System.EventHandler(this.cmEditAppointment_Click);
            // 
            // cmTakeTest
            // 
            this.cmTakeTest.Image = global::DVLD.Properties.Resources.Test_32;
            this.cmTakeTest.Name = "cmTakeTest";
            this.cmTakeTest.Size = new System.Drawing.Size(120, 22);
            this.cmTakeTest.Text = "Take Test";
            this.cmTakeTest.Click += new System.EventHandler(this.cmTakeTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Appointments";
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.ImageOptions.Image = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btnBookAppointment.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBookAppointment.Location = new System.Drawing.Point(648, 417);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(46, 40);
            this.btnBookAppointment.TabIndex = 5;
            this.btnBookAppointment.ToolTip = "Book an Appointment";
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(596, 619);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalApplicatoinInfo1
            // 
            this.ctrlLocalApplicatoinInfo1.Location = new System.Drawing.Point(12, 111);
            this.ctrlLocalApplicatoinInfo1.Name = "ctrlLocalApplicatoinInfo1";
            this.ctrlLocalApplicatoinInfo1.Size = new System.Drawing.Size(682, 304);
            this.ctrlLocalApplicatoinInfo1.TabIndex = 2;
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointments.Location = new System.Drawing.Point(12, 463);
            this.dgvTestAppointments.MainView = this.gridView1;
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.Size = new System.Drawing.Size(682, 150);
            this.dgvTestAppointments.TabIndex = 7;
            this.dgvTestAppointments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvTestAppointments;
            this.gridView1.Name = "gridView1";
            // 
            // frmListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 664);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLocalApplicatoinInfo1);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.pbTestPicture);
            this.Name = "frmListTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointments";
            this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestPicture)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestPicture;
        private System.Windows.Forms.Label lblTestType;
        private Applications.Controls.ctrlLocalApplicatoinInfo ctrlLocalApplicatoinInfo1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBookAppointment;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmEditAppointment;
        private System.Windows.Forms.ToolStripMenuItem cmTakeTest;
        private DevExpress.XtraGrid.GridControl dgvTestAppointments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}