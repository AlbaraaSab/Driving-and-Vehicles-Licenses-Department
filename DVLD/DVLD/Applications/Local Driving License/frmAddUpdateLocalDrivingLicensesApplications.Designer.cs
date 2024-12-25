namespace DVLD.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicensesApplications
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
            this.lblLocalDrivingIicenseApplicationTitle = new System.Windows.Forms.Label();
            this.tcApplicationInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPersonalInfo = new DevExpress.XtraTab.XtraTabPage();
            this.btnNextTab = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            this.tabApplicationInfo = new DevExpress.XtraTab.XtraTabPage();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblDLApplicationID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tcApplicationInfo)).BeginInit();
            this.tcApplicationInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocalDrivingIicenseApplicationTitle
            // 
            this.lblLocalDrivingIicenseApplicationTitle.AutoSize = true;
            this.lblLocalDrivingIicenseApplicationTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingIicenseApplicationTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLocalDrivingIicenseApplicationTitle.Location = new System.Drawing.Point(201, 33);
            this.lblLocalDrivingIicenseApplicationTitle.Name = "lblLocalDrivingIicenseApplicationTitle";
            this.lblLocalDrivingIicenseApplicationTitle.Size = new System.Drawing.Size(407, 25);
            this.lblLocalDrivingIicenseApplicationTitle.TabIndex = 0;
            this.lblLocalDrivingIicenseApplicationTitle.Text = "New Local Driving License Application";
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Location = new System.Drawing.Point(12, 77);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedTabPage = this.tabPersonalInfo;
            this.tcApplicationInfo.Size = new System.Drawing.Size(733, 440);
            this.tcApplicationInfo.TabIndex = 1;
            this.tcApplicationInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPersonalInfo,
            this.tabApplicationInfo});
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.btnNextTab);
            this.tabPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Size = new System.Drawing.Size(731, 415);
            this.tabPersonalInfo.Text = "Personal Info";
            // 
            // btnNextTab
            // 
            this.btnNextTab.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTab.Appearance.Options.UseFont = true;
            this.btnNextTab.ImageOptions.Image = global::DVLD.Properties.Resources.Next_32;
            this.btnNextTab.Location = new System.Drawing.Point(617, 366);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(94, 39);
            this.btnNextTab.TabIndex = 2;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(3, 13);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(714, 355);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tabApplicationInfo
            // 
            this.tabApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.tabApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.tabApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.tabApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tabApplicationInfo.Controls.Add(this.lblDLApplicationID);
            this.tabApplicationInfo.Controls.Add(this.pictureBox5);
            this.tabApplicationInfo.Controls.Add(this.pictureBox4);
            this.tabApplicationInfo.Controls.Add(this.pictureBox3);
            this.tabApplicationInfo.Controls.Add(this.pictureBox2);
            this.tabApplicationInfo.Controls.Add(this.pictureBox1);
            this.tabApplicationInfo.Controls.Add(this.label6);
            this.tabApplicationInfo.Controls.Add(this.label5);
            this.tabApplicationInfo.Controls.Add(this.label4);
            this.tabApplicationInfo.Controls.Add(this.label3);
            this.tabApplicationInfo.Controls.Add(this.label2);
            this.tabApplicationInfo.Name = "tabApplicationInfo";
            this.tabApplicationInfo.Size = new System.Drawing.Size(731, 415);
            this.tabApplicationInfo.Text = "Application Info";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(287, 336);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(38, 14);
            this.lblCreatedByUser.TabIndex = 14;
            this.lblCreatedByUser.Text = "[???]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(287, 281);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(38, 14);
            this.lblApplicationFees.TabIndex = 13;
            this.lblApplicationFees.Text = "[???]";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(290, 224);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(220, 21);
            this.cbLicenseClasses.TabIndex = 12;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(287, 171);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(38, 14);
            this.lblApplicationDate.TabIndex = 11;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lblDLApplicationID
            // 
            this.lblDLApplicationID.AutoSize = true;
            this.lblDLApplicationID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLApplicationID.Location = new System.Drawing.Point(287, 119);
            this.lblDLApplicationID.Name = "lblDLApplicationID";
            this.lblDLApplicationID.Size = new System.Drawing.Size(38, 14);
            this.lblDLApplicationID.TabIndex = 10;
            this.lblDLApplicationID.Text = "[???]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(241, 328);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(241, 275);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.pictureBox3.Location = new System.Drawing.Point(241, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(241, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(241, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "D. L. Application ID :";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(551, 532);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(651, 532);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateLocalDrivingLicensesApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 580);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcApplicationInfo);
            this.Controls.Add(this.lblLocalDrivingIicenseApplicationTitle);
            this.IconOptions.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.Name = "frmAddUpdateLocalDrivingLicensesApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicensesApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcApplicationInfo)).EndInit();
            this.tcApplicationInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabApplicationInfo.ResumeLayout(false);
            this.tabApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalDrivingIicenseApplicationTitle;
        private DevExpress.XtraTab.XtraTabControl tcApplicationInfo;
        private DevExpress.XtraTab.XtraTabPage tabPersonalInfo;
        private DevExpress.XtraTab.XtraTabPage tabApplicationInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private DevExpress.XtraEditors.SimpleButton btnNextTab;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblDLApplicationID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}