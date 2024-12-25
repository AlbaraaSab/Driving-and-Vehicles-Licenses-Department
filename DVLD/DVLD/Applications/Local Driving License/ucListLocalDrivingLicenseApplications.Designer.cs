namespace DVLD.Applications.Local_Driving_License
{
    partial class ucListLocalDrivingLicenseApplications
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.dgvLocalDrivingLicense = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.PersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.cbFilter = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnNewApplication = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.lblRowCounts = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocalDrivingLicense
            // 
            this.dgvLocalDrivingLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDrivingLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalDrivingLicense.EmbeddedNavigator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvLocalDrivingLicense.Location = new System.Drawing.Point(0, 71);
            this.dgvLocalDrivingLicense.MainView = this.gridView1;
            this.dgvLocalDrivingLicense.Name = "dgvLocalDrivingLicense";
            this.dgvLocalDrivingLicense.Size = new System.Drawing.Size(873, 418);
            this.dgvLocalDrivingLicense.TabIndex = 0;
            this.dgvLocalDrivingLicense.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.scheduleTestToolStripMenuItem,
            this.toolStripSeparator5,
            this.IssueLicenseToolStripMenuItem,
            this.toolStripSeparator4,
            this.ShowLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.PersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 216);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisionTestToolStripMenuItem,
            this.WrittenTestToolStripMenuItem,
            this.StreetTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Schedule_Test_32;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.scheduleTestToolStripMenuItem.Text = "Sechdule Test";
            // 
            // VisionTestToolStripMenuItem
            // 
            this.VisionTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Vision_Test_32;
            this.VisionTestToolStripMenuItem.Name = "VisionTestToolStripMenuItem";
            this.VisionTestToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.VisionTestToolStripMenuItem.Text = "Vision Test";
            this.VisionTestToolStripMenuItem.Click += new System.EventHandler(this.VisionTestToolStripMenuItem_Click);
            // 
            // WrittenTestToolStripMenuItem
            // 
            this.WrittenTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Written_Test_32;
            this.WrittenTestToolStripMenuItem.Name = "WrittenTestToolStripMenuItem";
            this.WrittenTestToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.WrittenTestToolStripMenuItem.Text = "Written Test";
            this.WrittenTestToolStripMenuItem.Click += new System.EventHandler(this.WrittenTestToolStripMenuItem_Click);
            // 
            // StreetTestToolStripMenuItem
            // 
            this.StreetTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Street_Test_32;
            this.StreetTestToolStripMenuItem.Name = "StreetTestToolStripMenuItem";
            this.StreetTestToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.StreetTestToolStripMenuItem.Text = "Street Test";
            this.StreetTestToolStripMenuItem.Click += new System.EventHandler(this.StreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(242, 6);
            // 
            // IssueLicenseToolStripMenuItem
            // 
            this.IssueLicenseToolStripMenuItem.Enabled = false;
            this.IssueLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.IssueLicenseToolStripMenuItem.Name = "IssueLicenseToolStripMenuItem";
            this.IssueLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.IssueLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueLicenseToolStripMenuItem.Click += new System.EventHandler(this.IssueLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(242, 6);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Enabled = false;
            this.ShowLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ShowLicenseToolStripMenuItem.Text = "Show License";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(242, 6);
            // 
            // PersonLicenseHistoryToolStripMenuItem
            // 
            this.PersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.PersonLicenseHistoryToolStripMenuItem.Name = "PersonLicenseHistoryToolStripMenuItem";
            this.PersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.PersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.PersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.PersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvLocalDrivingLicense;
            this.gridView1.Name = "gridView1";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barHeaderItem1,
            this.cbFilter,
            this.barEditItem3,
            this.barStaticItem2,
            this.lblRowCounts,
            this.btnNewApplication});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 10;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit2});
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.cbFilter, "", false, true, true, 142),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.barEditItem3, "", true, true, true, 132)});
            this.bar2.OptionsBar.MinHeight = 30;
            this.bar2.Text = "Tools";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Filter :";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // cbFilter
            // 
            this.cbFilter.Caption = "National No.\r\nLicense Class\r\nFullName\r\nApplication Status";
            this.cbFilter.Edit = this.repositoryItemComboBox1;
            this.cbFilter.Id = 4;
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            toolTipItem1.Text = "National No.";
            superToolTip1.Items.Add(toolTipItem1);
            this.cbFilter.SuperTip = superToolTip1;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit2;
            this.barEditItem3.Id = 6;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewApplication)});
            this.bar3.OptionsBar.MinHeight = 30;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.Caption = "New Application";
            this.btnNewApplication.Id = 9;
            this.btnNewApplication.ImageOptions.Image = global::DVLD.Properties.Resources.New_Application_32;
            this.btnNewApplication.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewApplication.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNewApplication.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewApplication_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblRowCounts)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.MinHeight = 30;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Records #";
            this.barStaticItem2.Id = 7;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // lblRowCounts
            // 
            this.lblRowCounts.Id = 8;
            this.lblRowCounts.Name = "lblRowCounts";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(873, 71);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(873, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 418);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(873, 71);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 418);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 2;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ucListLocalDrivingLicenseApplications
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLocalDrivingLicense);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucListLocalDrivingLicenseApplications";
            this.Size = new System.Drawing.Size(873, 519);
            this.Load += new System.EventHandler(this.ucListLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvLocalDrivingLicense;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem cbFilter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnNewApplication;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem lblRowCounts;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem StreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem PersonLicenseHistoryToolStripMenuItem;
    }
}
