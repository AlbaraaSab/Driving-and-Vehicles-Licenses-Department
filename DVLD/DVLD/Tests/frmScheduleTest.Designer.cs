namespace DVLD.Tests
{
    partial class frmScheduleTest
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
            this.ctrlScheduleTest1 = new DVLD.Tests.Controls.ctrlScheduleTest();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            this.ctrlScheduleTest1.Location = new System.Drawing.Point(15, 0);
            this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            this.ctrlScheduleTest1.Size = new System.Drawing.Size(437, 569);
            this.ctrlScheduleTest1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(190, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 636);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlScheduleTest1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlScheduleTest ctrlScheduleTest1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}