namespace DVLD.People.Controls
{
    partial class ucPeopleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPeopleList));
            this.dgvPeople = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAddNewPerson = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeople.Location = new System.Drawing.Point(0, 40);
            this.dgvPeople.MainView = this.gridView1;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(898, 489);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowPersonInfo,
            this.toolStripSeparator1,
            this.cmUpdate,
            this.cmDelete,
            this.toolStripSeparator2,
            this.cmPhoneCall,
            this.cmSendEmail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 126);
            // 
            // cmShowPersonInfo
            // 
            this.cmShowPersonInfo.Image = ((System.Drawing.Image)(resources.GetObject("cmShowPersonInfo.Image")));
            this.cmShowPersonInfo.Name = "cmShowPersonInfo";
            this.cmShowPersonInfo.Size = new System.Drawing.Size(166, 22);
            this.cmShowPersonInfo.Text = "Show Person Info";
            this.cmShowPersonInfo.Click += new System.EventHandler(this.cmShowPersonInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // cmUpdate
            // 
            this.cmUpdate.Image = ((System.Drawing.Image)(resources.GetObject("cmUpdate.Image")));
            this.cmUpdate.Name = "cmUpdate";
            this.cmUpdate.Size = new System.Drawing.Size(166, 22);
            this.cmUpdate.Text = "Update Person";
            this.cmUpdate.Click += new System.EventHandler(this.cmUpdate_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmDelete.Image")));
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(166, 22);
            this.cmDelete.Text = "Delete Person";
            this.cmDelete.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // cmPhoneCall
            // 
            this.cmPhoneCall.Image = global::DVLD.Properties.Resources.call_32;
            this.cmPhoneCall.Name = "cmPhoneCall";
            this.cmPhoneCall.Size = new System.Drawing.Size(166, 22);
            this.cmPhoneCall.Text = "Phone Call";
            this.cmPhoneCall.Click += new System.EventHandler(this.cmPhoneCall_Click);
            // 
            // cmSendEmail
            // 
            this.cmSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("cmSendEmail.Image")));
            this.cmSendEmail.Name = "cmSendEmail";
            this.cmSendEmail.Size = new System.Drawing.Size(166, 22);
            this.cmSendEmail.Text = "Send Email";
            this.cmSendEmail.Click += new System.EventHandler(this.cmSendEmail_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvPeople;
            this.gridView1.Name = "gridView1";
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
            this.btnAddNewPerson});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddNewPerson)});
            this.bar1.Text = "Tools";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Caption = "New Person";
            this.btnAddNewPerson.Id = 0;
            this.btnAddNewPerson.ImageOptions.Image = global::DVLD.Properties.Resources.Add_New_User_32;
            this.btnAddNewPerson.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddNewPerson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNewPerson_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(898, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 529);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(898, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(898, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
            // 
            // ucPeopleList
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucPeopleList";
            this.Size = new System.Drawing.Size(898, 529);
            this.Load += new System.EventHandler(this.ucPeopleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvPeople;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAddNewPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripMenuItem cmShowPersonInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem cmSendEmail;
    }
}
