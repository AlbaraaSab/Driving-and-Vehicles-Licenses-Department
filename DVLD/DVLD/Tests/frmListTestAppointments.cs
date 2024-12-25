using System;
using System.Windows.Forms;
using DVLD.Applications.Controls;
using DVLD.Global_Classes;
using DVLD.Properties;
using DVLD_Business;

namespace DVLD.Tests
{
    public partial class frmListTestAppointments : DevExpress.XtraEditors.XtraForm
    {
        int TestTypeID;
        int LocalDrivingLicenseApplicationID;


        public frmListTestAppointments(int localDrivingLicenseApplicationID ,int testTypeID)
        {
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            InitializeComponent();
        }

        private void _ReloadDataGridView()
        {
            //dgvAppointments.DataSource = clsTestAppointment.LoadAppointments(LocalDrivingLicenseApplicationID, TestTypeID);
            dgvTestAppointments.DataSource = clsTestAppointment.LoadAppointments(LocalDrivingLicenseApplicationID, TestTypeID);
            gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void _loadData()
        {
            ctrlLocalApplicatoinInfo1.LoadApplicationData(LocalDrivingLicenseApplicationID);

            if (TestTypeID == 1)
            {
                pbTestPicture.Image = Resources.Vision_512;
                lblTestType.Text = "Vision Test Appointmetn";
                this.Text = "Vision Test Appointmetn";
            }
            else if (TestTypeID == 2)
            {
                pbTestPicture.Image = Resources.Written_Test_512;
                lblTestType.Text = "Wriiten Test Appointmetn";
                this.Text = "Written Test Appointmetn";
            }
            else
            {
                pbTestPicture.Image = Resources.Street_Test_32;
                lblTestType.Text = "Street Test Appointmetn";
                this.Text = "Street Test Appointmetn";
            }
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _loadData();
            _ReloadDataGridView();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.CheckPerviousAppointment(LocalDrivingLicenseApplicationID, TestTypeID))
            {
                MessageBox.Show("Person Already has an avtive appointment for this test, You connot add new appointment.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            else if (clsTest.IsTestPassed(LocalDrivingLicenseApplicationID, TestTypeID))
            {
                MessageBox.Show("Person already has passed this test. You cannot Retake this test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (clsTest.IsTestFailed(LocalDrivingLicenseApplicationID, TestTypeID))
            {

                clsLocalDrivingLicenseApplications localDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID(LocalDrivingLicenseApplicationID);

                clsApplicatonTypes applicatonTypes = clsApplicatonTypes.FindApplicationType(7);

                clsApplication reTakeTestApp = new clsApplication();

                reTakeTestApp.ApplicantPersonID = localDrivingLicenseApplication.ApplicantPersonID;
                reTakeTestApp.ApplicationDate = DateTime.Now;
                reTakeTestApp.ApplicationTypeID = 7;
                reTakeTestApp.ApplicationStatus = 1;
                reTakeTestApp.LastStatusDate = DateTime.Now;
                reTakeTestApp.PaidFees = applicatonTypes.ApplicationFees;
                reTakeTestApp.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                reTakeTestApp.Save();

                frmScheduleTest scheduleTest = new frmScheduleTest(-1, LocalDrivingLicenseApplicationID, TestTypeID, reTakeTestApp.ApplicationID);
                scheduleTest.ShowDialog();
                _ReloadDataGridView();
                _loadData();
            }
            else
            {
                frmScheduleTest scheduleTest = new frmScheduleTest(-1, LocalDrivingLicenseApplicationID, TestTypeID);
                scheduleTest.ShowDialog();
                _ReloadDataGridView();
                _loadData();
            }
        }

        private void cmEditAppointment_Click(object sender, EventArgs e)
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

            frmScheduleTest scheduleTest = new frmScheduleTest((int)CellValue, LocalDrivingLicenseApplicationID, TestTypeID);
            scheduleTest.ShowDialog();
            _ReloadDataGridView();
        }

        private void cmTakeTest_Click(object sender, EventArgs e)
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

            frmTakeTest takeTest = new frmTakeTest((int)CellValue);
            takeTest.ShowDialog();
            _ReloadDataGridView();
            _loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
