using DVLD.Licenses;
using DVLD.Licenses.Local_Licenses;
using DVLD.Tests;
using DVLD_Business;
using System;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class ucListLocalDrivingLicenseApplications : DevExpress.DXperience.Demos.TutorialControlBase //UserControl
    {
        clsLocalDrivingLicenseApplications LDLApp;

        public ucListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void _ReloadDataGridView()
        {
            dgvLocalDrivingLicense.DataSource = clsLocalDrivingLicenseApplications.LoadAllLocalDrivingLicenseApplications();
            gridView1.OptionsBehavior.ReadOnly = true;
            lblRowCounts.Caption = gridView1.RowCount.ToString();
        }

        private void ucListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _ReloadDataGridView();
        }

        private void btnNewApplication_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddUpdateLocalDrivingLicensesApplications localDrivingLicensesApplications = new frmAddUpdateLocalDrivingLicensesApplications(-1);
            localDrivingLicensesApplications.ShowDialog();
            _ReloadDataGridView();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            LDLApp = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID((int)CellValue);

            clsApplication.CancelApplication(LDLApp.ApplicationID);
            _ReloadDataGridView();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            frmShowlocalApplicationInfo showApplicationInfo = new frmShowlocalApplicationInfo((int)CellValue);
            showApplicationInfo.ShowDialog();
            _ReloadDataGridView();
        }

        private void VisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            frmListTestAppointments listTestAppointments = new frmListTestAppointments((int)CellValue, 1);
            listTestAppointments.ShowDialog();
            _ReloadDataGridView();
        }

        private void WrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            frmListTestAppointments listTestAppointments = new frmListTestAppointments((int)CellValue, 2);
            listTestAppointments.ShowDialog();
            _ReloadDataGridView();
        }

        private void StreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            frmListTestAppointments listTestAppointments = new frmListTestAppointments((int)CellValue, 3);
            listTestAppointments.ShowDialog();
            _ReloadDataGridView();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            int PassedTest = clsLocalDrivingLicenseApplications.NumberOfPassedTest((int)CellValue);

            LDLApp = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID((int)CellValue);            

            if (PassedTest == 0)
            {
                VisionTestToolStripMenuItem.Enabled = true;
                WrittenTestToolStripMenuItem.Enabled = false;
                StreetTestToolStripMenuItem.Enabled = false;
                IssueLicenseToolStripMenuItem.Enabled = false;
                ShowLicenseToolStripMenuItem.Enabled = false;
                return;
            }
            else if (PassedTest == 1)
            {
                VisionTestToolStripMenuItem.Enabled = false;
                WrittenTestToolStripMenuItem.Enabled = true;
                StreetTestToolStripMenuItem.Enabled = false;
                IssueLicenseToolStripMenuItem.Enabled = false;
                ShowLicenseToolStripMenuItem.Enabled = false;
                return;
            }
            else if (PassedTest == 2)
            {
                VisionTestToolStripMenuItem.Enabled = false;
                WrittenTestToolStripMenuItem.Enabled = false;
                StreetTestToolStripMenuItem.Enabled = true;
                IssueLicenseToolStripMenuItem.Enabled = false;
                ShowLicenseToolStripMenuItem.Enabled = false;
                return;
            }
            else if (PassedTest == 3 && LDLApp.ApplicationStatus != 3)
            {
                VisionTestToolStripMenuItem.Enabled = false;
                WrittenTestToolStripMenuItem.Enabled = false;
                StreetTestToolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;
                IssueLicenseToolStripMenuItem.Enabled= true;
                ShowLicenseToolStripMenuItem.Enabled= false;
                return;
            }
            else if (PassedTest == 3 && LDLApp.ApplicationStatus == 3)
            {
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                VisionTestToolStripMenuItem.Enabled = false;
                WrittenTestToolStripMenuItem.Enabled = false;
                StreetTestToolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;
                IssueLicenseToolStripMenuItem.Enabled = false;
                ShowLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void IssueLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            frmIssueDriverLicenseFirstTime issueDriverLicenseFirstTime = new frmIssueDriverLicenseFirstTime((int)CellValue);
            issueDriverLicenseFirstTime.ShowDialog();
            _ReloadDataGridView();
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            clsLocalDrivingLicenseApplications localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID((int)CellValue);
            clsLicense license = clsLicense.FindByApplicationID(localDrivingLicenseApplications.ApplicationID);

            frmShowLicenseInfo showlocalApplicationInfo = new frmShowLicenseInfo(license.LicenseID);
            showlocalApplicationInfo.ShowDialog();
        }

        private void PersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            LDLApp = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID((int)CellValue);

            frmShowPersonLicensesHistory showPersonLicensesHistory = new frmShowPersonLicensesHistory(LDLApp.ApplicantPersonID);
            showPersonLicensesHistory.ShowDialog();
        }
    }
}
