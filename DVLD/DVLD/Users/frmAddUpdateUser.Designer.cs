namespace DVLD.Users
{
    partial class frmAddUpdateUser
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
            this.components = new System.ComponentModel.Container();
            this.lblAddUpdateTitle = new System.Windows.Forms.Label();
            this.tcUserInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPersonalInfo = new DevExpress.XtraTab.XtraTabPage();
            this.btnNextTab = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            this.tabLoginInfo = new DevExpress.XtraTab.XtraTabPage();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tcUserInfo)).BeginInit();
            this.tcUserInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddUpdateTitle
            // 
            this.lblAddUpdateTitle.AutoSize = true;
            this.lblAddUpdateTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdateTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAddUpdateTitle.Location = new System.Drawing.Point(307, 33);
            this.lblAddUpdateTitle.Name = "lblAddUpdateTitle";
            this.lblAddUpdateTitle.Size = new System.Drawing.Size(159, 25);
            this.lblAddUpdateTitle.TabIndex = 0;
            this.lblAddUpdateTitle.Text = "Add New User";
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Location = new System.Drawing.Point(13, 73);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedTabPage = this.tabPersonalInfo;
            this.tcUserInfo.Size = new System.Drawing.Size(718, 428);
            this.tcUserInfo.TabIndex = 1;
            this.tcUserInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPersonalInfo,
            this.tabLoginInfo});
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.btnNextTab);
            this.tabPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Size = new System.Drawing.Size(716, 403);
            this.tabPersonalInfo.Text = "Personal Info";
            // 
            // btnNextTab
            // 
            this.btnNextTab.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTab.Appearance.Options.UseFont = true;
            this.btnNextTab.ImageOptions.Image = global::DVLD.Properties.Resources.Next_32;
            this.btnNextTab.Location = new System.Drawing.Point(615, 354);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(94, 39);
            this.btnNextTab.TabIndex = 1;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(716, 348);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.chkIsActive);
            this.tabLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tabLoginInfo.Controls.Add(this.txtPassword);
            this.tabLoginInfo.Controls.Add(this.txtUserName);
            this.tabLoginInfo.Controls.Add(this.lblUserID);
            this.tabLoginInfo.Controls.Add(this.label4);
            this.tabLoginInfo.Controls.Add(this.label3);
            this.tabLoginInfo.Controls.Add(this.label2);
            this.tabLoginInfo.Controls.Add(this.label1);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Size = new System.Drawing.Size(716, 403);
            this.tabLoginInfo.Text = "Login Info";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(298, 275);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(68, 17);
            this.chkIsActive.TabIndex = 8;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(298, 222);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(129, 20);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(298, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(298, 132);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(129, 20);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(299, 90);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(38, 14);
            this.lblUserID.TabIndex = 4;
            this.lblUserID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(537, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(637, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 567);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.lblAddUpdateTitle);
            this.IconOptions.Image = global::DVLD.Properties.Resources.Add_New_User_32;
            this.Name = "frmAddUpdateUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcUserInfo)).EndInit();
            this.tcUserInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUpdateTitle;
        private DevExpress.XtraTab.XtraTabControl tcUserInfo;
        private DevExpress.XtraTab.XtraTabPage tabPersonalInfo;
        private DevExpress.XtraTab.XtraTabPage tabLoginInfo;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNextTab;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}