namespace DVLD.Licenses
{
    partial class frmShowLicenseInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlLicenseInfo1 = new DVLD.Licenses.Controls.ctrlLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(333, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(285, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver License Info";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(701, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(12, 142);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(778, 313);
            this.ctrlLicenseInfo1.TabIndex = 4;
            // 
            // frmShowLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 506);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmShowLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local License Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private Controls.ctrlLicenseInfo ctrlLicenseInfo1;
    }
}