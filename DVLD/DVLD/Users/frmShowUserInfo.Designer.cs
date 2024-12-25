namespace DVLD.Users.Controls
{
    partial class frmShowUserInfo
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
            this.ctrlUserCard1 = new DVLD.Users.Controls.ctrlUserCard();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Location = new System.Drawing.Point(2, 3);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(736, 364);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(641, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 420);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlUserCard1);
            this.IconOptions.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}