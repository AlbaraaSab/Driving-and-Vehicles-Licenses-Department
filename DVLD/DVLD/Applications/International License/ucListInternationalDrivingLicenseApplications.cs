using DVLD.Licenses;
using DVLD.Licenses.International_Licenses;
using DVLD.People;
using DVLD_Business;
using System;

namespace DVLD.Applications.International_License
{
    public partial class ucListInternationalDrivingLicenseApplications : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucListInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void _LoadInternationalLicesnseData()
        {
            dgvInternationalDrivingLicenses.DataSource = clsInternationalLicense.GetAllInternationalDrivingLicesnes();
            gridView1.OptionsBehavior.ReadOnly = true;
            lblRecord.Caption = gridView1.RowCount.ToString();
        }

        private void ucListInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadInternationalLicesnseData();
        }

        private void btnIssueLicense_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIssueInternationalDrivingLicense issueInternationalDrivingLicense = new frmIssueInternationalDrivingLicense();
            issueInternationalDrivingLicense.ShowDialog();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]);
                }
            }

            clsApplication application = clsApplication.Find((int)CellValue);

            frmShowPersonInfo showPersonInfo = new frmShowPersonInfo(application.ApplicantPersonID);
            showPersonInfo.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
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
            clsInternationalLicense internationalLicense = clsInternationalLicense.Find((int)CellValue);
            clsApplication application = clsApplication.Find(internationalLicense.ApplicationID);

            frmShowInternationlLicenseInfo showInternationlLicenseInfo = new frmShowInternationlLicenseInfo((int)CellValue, application.ApplicantPersonID);
            showInternationlLicenseInfo.ShowDialog();
        }

        private void showPersonLinceseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[1]);
                }
            }

            clsApplication application = clsApplication.Find((int)CellValue);

            frmShowPersonLicensesHistory showPersonLicensesHistory = new frmShowPersonLicensesHistory(application.ApplicantPersonID);
            showPersonLicensesHistory.ShowDialog();
        }
    }
}
