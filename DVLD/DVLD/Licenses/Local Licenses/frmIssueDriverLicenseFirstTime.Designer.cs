namespace DVLD.Licenses.Local_Licenses
{
    partial class frmIssueDriverLicenseFirstTime
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
            this.ctrlLocalApplicatoinInfo1 = new DVLD.Applications.Controls.ctrlLocalApplicatoinInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.btnIssueLicense = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLocalApplicatoinInfo1
            // 
            this.ctrlLocalApplicatoinInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLocalApplicatoinInfo1.Name = "ctrlLocalApplicatoinInfo1";
            this.ctrlLocalApplicatoinInfo1.Size = new System.Drawing.Size(682, 303);
            this.ctrlLocalApplicatoinInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(73, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(119, 327);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(575, 96);
            this.txtNotes.TabIndex = 3;
            this.txtNotes.Text = "";
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.ImageOptions.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssueLicense.Location = new System.Drawing.Point(600, 434);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(95, 36);
            this.btnIssueLicense.TabIndex = 4;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(499, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 490);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLocalApplicatoinInfo1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmIssueDriverLicenseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driver License First Time";
            this.Load += new System.EventHandler(this.frmIssueDriverLicenseFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Controls.ctrlLocalApplicatoinInfo ctrlLocalApplicatoinInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtNotes;
        private DevExpress.XtraEditors.SimpleButton btnIssueLicense;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}