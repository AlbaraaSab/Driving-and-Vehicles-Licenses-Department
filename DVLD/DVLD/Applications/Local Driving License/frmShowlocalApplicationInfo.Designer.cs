namespace DVLD.Applications.Local_Driving_License
{
    partial class frmShowlocalApplicationInfo
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
            this.ctrlApplicatoinInfo1 = new DVLD.Applications.Controls.ctrlLocalApplicatoinInfo();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ctrlApplicatoinInfo1
            // 
            this.ctrlApplicatoinInfo1.Location = new System.Drawing.Point(7, 12);
            this.ctrlApplicatoinInfo1.Name = "ctrlApplicatoinInfo1";
            this.ctrlApplicatoinInfo1.Size = new System.Drawing.Size(662, 308);
            this.ctrlApplicatoinInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(578, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowlocalApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 372);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlApplicatoinInfo1);
            this.IconOptions.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.Name = "frmShowlocalApplicationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Local Application Info";
            this.Load += new System.EventHandler(this.frmShowlocalApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlLocalApplicatoinInfo ctrlApplicatoinInfo1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}