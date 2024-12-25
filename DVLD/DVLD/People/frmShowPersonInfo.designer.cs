using DVLD_Business;

namespace DVLD.People
{
    partial class frmShowPersonInfo
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
            this.ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(712, 279);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // frmShowPersonInfo
            // 
            this.ClientSize = new System.Drawing.Size(712, 279);
            this.Controls.Add(this.ctrlPersonCard1);
            this.IconOptions.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Information";
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.Label label1;
        private Controls.ctrlPersonCard ctrlPersonCard1;
    }
}