namespace DVLD.Applications.Replace_Lost_or_Damaged_License
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            this.ctrlLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlLicenseInfoWithFilter();
            this.btnShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnIssueLicense = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCreatedByID = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.License = null;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(13, 13);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.PersonID = 0;
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(781, 398);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<DVLD_Business.clsLicense, int>(this.ctrlLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.AutoSize = true;
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(199, 564);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(140, 16);
            this.btnShowLicenseInfo.TabIndex = 10;
            this.btnShowLicenseInfo.TabStop = true;
            this.btnShowLicenseInfo.Text = "Show New License Info";
            this.btnShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnShowLicenseInfo_LinkClicked);
            // 
            // btnShowLicenseHistory
            // 
            this.btnShowLicenseHistory.AutoSize = true;
            this.btnShowLicenseHistory.Enabled = false;
            this.btnShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(39, 564);
            this.btnShowLicenseHistory.Name = "btnShowLicenseHistory";
            this.btnShowLicenseHistory.Size = new System.Drawing.Size(128, 16);
            this.btnShowLicenseHistory.TabIndex = 9;
            this.btnShowLicenseHistory.TabStop = true;
            this.btnShowLicenseHistory.Text = "Show License History";
            this.btnShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnShowLicenseHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Options.UseTextOptions = true;
            this.btnClose.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(553, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Appearance.Options.UseTextOptions = true;
            this.btnIssueLicense.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnIssueLicense.ImageOptions.Image = global::DVLD.Properties.Resources.International_32;
            this.btnIssueLicense.Location = new System.Drawing.Point(648, 556);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(141, 35);
            this.btnIssueLicense.TabIndex = 7;
            this.btnIssueLicense.Text = "Issue Replacement";
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCreatedByID);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.lblReplacedLicenseID);
            this.groupBox1.Controls.Add(this.lblApplicationID);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info for License Replacement";
            // 
            // lblCreatedByID
            // 
            this.lblCreatedByID.AutoSize = true;
            this.lblCreatedByID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByID.Location = new System.Drawing.Point(551, 103);
            this.lblCreatedByID.Name = "lblCreatedByID";
            this.lblCreatedByID.Size = new System.Drawing.Size(38, 14);
            this.lblCreatedByID.TabIndex = 63;
            this.lblCreatedByID.Text = "[???]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(206, 96);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(42, 14);
            this.lblApplicationFees.TabIndex = 62;
            this.lblApplicationFees.Text = "[???] ";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(206, 68);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(38, 14);
            this.lblApplicationDate.TabIndex = 61;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.Location = new System.Drawing.Point(551, 73);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(38, 14);
            this.lblOldLicenseID.TabIndex = 59;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(551, 41);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(38, 14);
            this.lblReplacedLicenseID.TabIndex = 58;
            this.lblReplacedLicenseID.Text = "[???]";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(206, 36);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(38, 14);
            this.lblApplicationID.TabIndex = 56;
            this.lblApplicationID.Text = "[???]";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pictureBox9.Location = new System.Drawing.Point(513, 98);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(26, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 55;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.pictureBox11.Location = new System.Drawing.Point(513, 34);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(26, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 53;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.pictureBox12.Location = new System.Drawing.Point(513, 66);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(26, 25);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 52;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox5.Location = new System.Drawing.Point(170, 94);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox6.Location = new System.Drawing.Point(171, 62);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox8.Location = new System.Drawing.Point(170, 30);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 48;
            this.pictureBox8.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(374, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 14);
            this.label10.TabIndex = 47;
            this.label10.Text = "Replaced License ID :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(374, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 14);
            this.label11.TabIndex = 46;
            this.label11.Text = "Old License ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(374, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 14);
            this.label13.TabIndex = 44;
            this.label13.Text = "Created By :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 14);
            this.label8.TabIndex = 43;
            this.label8.Text = "Application Fees :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 14);
            this.label7.TabIndex = 42;
            this.label7.Text = "Application Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 14);
            this.label5.TabIndex = 40;
            this.label5.Text = "L. R. Application ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLostLicense);
            this.groupBox2.Controls.Add(this.rbDamagedLicense);
            this.groupBox2.Location = new System.Drawing.Point(578, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 58);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replaced For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(23, 35);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(83, 17);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(23, 16);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(108, 17);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmReplaceLostOrDamagedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace Lost Or Damaged License Application";
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Local_Licenses.Controls.ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel btnShowLicenseInfo;
        private System.Windows.Forms.LinkLabel btnShowLicenseHistory;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnIssueLicense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCreatedByID;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
    }
}