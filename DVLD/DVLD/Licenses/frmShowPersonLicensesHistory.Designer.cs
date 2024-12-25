namespace DVLD.Licenses
{
    partial class frmShowPersonLicensesHistory
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlDriverLicenses1 = new DVLD.Licenses.Controls.ctrlDriverLicenses();
            this.ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(650, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(12, 361);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(729, 228);
            this.ctrlDriverLicenses1.TabIndex = 1;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(12, 7);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(735, 346);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmShowPersonLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 647);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.IconOptions.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.Name = "frmShowPersonLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Person Licenses History";
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Controls.ctrlDriverLicenses ctrlDriverLicenses1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}