namespace DVLD.Licenses.Local_Licenses.Controls
{
    partial class ctrlLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtLicenseID = new DevExpress.XtraEditors.TextEdit();
            this.btnFindLicense = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblDriverID = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblIssueReason = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblIsDetained = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Controls.Add(this.btnFindLicense);
            this.gbFilter.Controls.Add(this.label14);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(773, 72);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(107, 32);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtLicenseID.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtLicenseID.Properties.MaskSettings.Set("mask", "d");
            this.txtLicenseID.Size = new System.Drawing.Size(146, 20);
            this.txtLicenseID.TabIndex = 7;
            // 
            // btnFindLicense
            // 
            this.btnFindLicense.ImageOptions.Image = global::DVLD.Properties.Resources.License_View_32;
            this.btnFindLicense.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindLicense.Location = new System.Drawing.Point(259, 26);
            this.btnFindLicense.Name = "btnFindLicense";
            this.btnFindLicense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindLicense.Size = new System.Drawing.Size(47, 34);
            this.btnFindLicense.TabIndex = 4;
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindLicense_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "License ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = " Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "License ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "National No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Issue Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Issue Reason :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Notes :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(331, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 14);
            this.label13.TabIndex = 8;
            this.label13.Text = "Is Detained :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 14);
            this.label12.TabIndex = 9;
            this.label12.Text = "Expiration Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(331, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "Driver ID :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Date of Birth :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(331, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Is Active :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.pictureBox1.Location = new System.Drawing.Point(122, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Person_32;
            this.pictureBox2.Location = new System.Drawing.Point(122, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(122, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(123, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.Man_32;
            this.pictureBox8.Location = new System.Drawing.Point(122, 173);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox7.Location = new System.Drawing.Point(122, 237);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox6.Location = new System.Drawing.Point(123, 205);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox5.Location = new System.Drawing.Point(123, 269);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::DVLD.Properties.Resources.Question_32;
            this.pictureBox13.Location = new System.Drawing.Point(447, 145);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(26, 25);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 21;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox12.Location = new System.Drawing.Point(447, 209);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(26, 25);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 22;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox11.Location = new System.Drawing.Point(447, 177);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(26, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox10.Location = new System.Drawing.Point(446, 241);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(26, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Question_32;
            this.pictureBox9.Location = new System.Drawing.Point(447, 273);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(26, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(607, 8);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(154, 162);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 26;
            this.pbPersonImage.TabStop = false;
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClass.Location = new System.Drawing.Point(156, 52);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(38, 14);
            this.lblLicenseClass.TabIndex = 27;
            this.lblLicenseClass.Text = "[???]";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPersonName.Location = new System.Drawing.Point(157, 82);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(49, 18);
            this.lblPersonName.TabIndex = 28;
            this.lblPersonName.Text = "[???]";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(157, 115);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(38, 14);
            this.lblLicenseID.TabIndex = 29;
            this.lblLicenseID.Text = "[???]";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.Location = new System.Drawing.Point(157, 147);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(42, 14);
            this.lblNationalNo.TabIndex = 30;
            this.lblNationalNo.Text = "[???] ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(158, 179);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(38, 14);
            this.lblGender.TabIndex = 31;
            this.lblGender.Text = "[???]";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(158, 244);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(38, 14);
            this.lblIssueDate.TabIndex = 32;
            this.lblIssueDate.Text = "[???]";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(485, 151);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(38, 14);
            this.lblIsActive.TabIndex = 33;
            this.lblIsActive.Text = "[???]";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(485, 184);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(38, 14);
            this.lblDateOfBirth.TabIndex = 34;
            this.lblDateOfBirth.Text = "[???]";
            // 
            // lblDriverID
            // 
            this.lblDriverID.AutoSize = true;
            this.lblDriverID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverID.Location = new System.Drawing.Point(485, 217);
            this.lblDriverID.Name = "lblDriverID";
            this.lblDriverID.Size = new System.Drawing.Size(38, 14);
            this.lblDriverID.TabIndex = 35;
            this.lblDriverID.Text = "[???]";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(485, 245);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(38, 14);
            this.lblExpirationDate.TabIndex = 36;
            this.lblExpirationDate.Text = "[???]";
            // 
            // lblIssueReason
            // 
            this.lblIssueReason.AutoSize = true;
            this.lblIssueReason.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueReason.Location = new System.Drawing.Point(159, 208);
            this.lblIssueReason.Name = "lblIssueReason";
            this.lblIssueReason.Size = new System.Drawing.Size(38, 14);
            this.lblIssueReason.TabIndex = 37;
            this.lblIssueReason.Text = "[???]";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(158, 271);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(42, 14);
            this.lblNotes.TabIndex = 38;
            this.lblNotes.Text = "[???] ";
            // 
            // lblIsDetained
            // 
            this.lblIsDetained.AutoSize = true;
            this.lblIsDetained.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsDetained.Location = new System.Drawing.Point(485, 278);
            this.lblIsDetained.Name = "lblIsDetained";
            this.lblIsDetained.Size = new System.Drawing.Size(38, 14);
            this.lblIsDetained.TabIndex = 39;
            this.lblIsDetained.Text = "[???]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIsDetained);
            this.groupBox1.Controls.Add(this.lblNotes);
            this.groupBox1.Controls.Add(this.lblIssueReason);
            this.groupBox1.Controls.Add(this.lblExpirationDate);
            this.groupBox1.Controls.Add(this.lblDriverID);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblNationalNo);
            this.groupBox1.Controls.Add(this.lblLicenseID);
            this.groupBox1.Controls.Add(this.lblPersonName);
            this.groupBox1.Controls.Add(this.lblLicenseClass);
            this.groupBox1.Controls.Add(this.pbPersonImage);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.pictureBox13);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License Info";
            // 
            // ctrlLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(781, 398);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private DevExpress.XtraEditors.TextEdit txtLicenseID;
        private DevExpress.XtraEditors.SimpleButton btnFindLicense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblDriverID;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblIssueReason;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblIsDetained;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
