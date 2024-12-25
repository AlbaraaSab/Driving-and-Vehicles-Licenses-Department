namespace DVLD.Users.Controls
{
    partial class ucUsersList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUsersList));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAddNewUser = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmShowUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvUsers = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddNewUser});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewUser)});
            this.bar1.Text = "Tools";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Caption = "New User";
            this.btnAddNewUser.Id = 0;
            this.btnAddNewUser.ImageOptions.Image = global::DVLD.Properties.Resources.Add_New_User_32;
            this.btnAddNewUser.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddNewUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNewUser_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(809, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(809, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(809, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowUserInfo,
            this.toolStripSeparator1,
            this.cmUpdate,
            this.cmDelete,
            this.cmChangePassword,
            this.toolStripSeparator2,
            this.cmPhoneCall,
            this.cmSendEmail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 148);
            // 
            // cmShowUserInfo
            // 
            this.cmShowUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("cmShowUserInfo.Image")));
            this.cmShowUserInfo.Name = "cmShowUserInfo";
            this.cmShowUserInfo.Size = new System.Drawing.Size(168, 22);
            this.cmShowUserInfo.Text = "Show User Info";
            this.cmShowUserInfo.Click += new System.EventHandler(this.cmShowUserInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // cmUpdate
            // 
            this.cmUpdate.Image = ((System.Drawing.Image)(resources.GetObject("cmUpdate.Image")));
            this.cmUpdate.Name = "cmUpdate";
            this.cmUpdate.Size = new System.Drawing.Size(168, 22);
            this.cmUpdate.Text = "Edit User";
            this.cmUpdate.Click += new System.EventHandler(this.cmUpdate_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmDelete.Image")));
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(168, 22);
            this.cmDelete.Text = "Delete User";
            this.cmDelete.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // cmChangePassword
            // 
            this.cmChangePassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.cmChangePassword.Name = "cmChangePassword";
            this.cmChangePassword.Size = new System.Drawing.Size(168, 22);
            this.cmChangePassword.Text = "Change Password";
            this.cmChangePassword.Click += new System.EventHandler(this.cmChangePassword_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // cmPhoneCall
            // 
            this.cmPhoneCall.Image = global::DVLD.Properties.Resources.call_32;
            this.cmPhoneCall.Name = "cmPhoneCall";
            this.cmPhoneCall.Size = new System.Drawing.Size(168, 22);
            this.cmPhoneCall.Text = "Phone Call";
            this.cmPhoneCall.Click += new System.EventHandler(this.cmPhoneCall_Click);
            // 
            // cmSendEmail
            // 
            this.cmSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("cmSendEmail.Image")));
            this.cmSendEmail.Name = "cmSendEmail";
            this.cmSendEmail.Size = new System.Drawing.Size(168, 22);
            this.cmSendEmail.Text = "Send Email";
            this.cmSendEmail.Click += new System.EventHandler(this.cmSendEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter : ";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(581, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(142, 21);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.comboBox1.Location = new System.Drawing.Point(581, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "UserName",
            "Is Active"});
            this.comboBox2.Location = new System.Drawing.Point(443, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(729, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(66, 23);
            this.search.TabIndex = 18;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvUsers;
            this.gridView1.Name = "gridView1";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 40);
            this.dgvUsers.MainView = this.gridView1;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(809, 423);
            this.dgvUsers.TabIndex = 5;
            this.dgvUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ucUsersList
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucUsersList";
            this.Size = new System.Drawing.Size(809, 463);
            this.Load += new System.EventHandler(this.ucUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAddNewUser;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmShowUserInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem cmSendEmail;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ToolStripMenuItem cmChangePassword;
        private DevExpress.XtraGrid.GridControl dgvUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
