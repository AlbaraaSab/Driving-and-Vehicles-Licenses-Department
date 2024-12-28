using DVLD.Global_Classes;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Tests.Controls
{
    public partial class ctrlScheduleTest : UserControl
    {
        int _localDrivingLicenseAppID;
        int _testTypeID;
        int _reTakeApplicationID;
        int _appointmentID;

        enum enMode { Add = 1, Update = 2 }
        enMode Mode;


        clsLocalDrivingLicenseApplications localDrivingLicenseApplications;
        clsTestTypes TestTypes;      
        clsApplication reTakeApplication;        
        clsTestAppointment appointment;
        clsTestAppointment reTakeAppointment;

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }


        public void LoadAppointment(int appointmentID, int localDrivingLicenseAppID, int testTypeID, int reTakeApplicationID)
        {
            _localDrivingLicenseAppID = localDrivingLicenseAppID;
            _testTypeID = testTypeID;
            _appointmentID = appointmentID;
            _reTakeApplicationID = reTakeApplicationID;

            if (_appointmentID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Update;
            }

            _loadTestTypeDate();
            _FillAppointmentData();

        }

        private void _loadTestTypeDate()
        {
            localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID(_localDrivingLicenseAppID);
            TestTypes = clsTestTypes.FindTestType(_testTypeID);

            int Trail = clsTest.TestTrail(_localDrivingLicenseAppID, _testTypeID);

            if (TestTypes.TestTypeID == 1)
            {
                gbTestType.Text = TestTypes.TestTypeTitle.ToString();
                pbTestPicture.Image = Resources.Vision_512;
            }
            else if (TestTypes.TestTypeID == 2)
            {
                gbTestType.Text = TestTypes.TestTypeTitle.ToString();
                pbTestPicture.Image = Resources.Written_Test_512;
            }
            else
            {
                gbTestType.Text = TestTypes.TestTypeTitle.ToString();
                pbTestPicture.Image = Resources.driving_test_512;
            }

            lblDrivingLocalAppID.Text = localDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = localDrivingLicenseApplications.LicenseClassInfo.ClassName;
            lblApplicantName.Text = localDrivingLicenseApplications.PersonInfo.FullName;
            lblTrail.Text = Trail.ToString();
            lblFees.Text = TestTypes.TestTypeFees.ToString("0");

            lblTotalFees.Text = TestTypes.TestTypeFees.ToString("0");

            if (_reTakeApplicationID != -1)
            {
                gbRetakeTestInfo.Enabled = true;

                lblRetakeTitle.Visible = true;
                lblTitle.Visible = false;

                reTakeApplication = clsApplication.Find(_reTakeApplicationID);
                reTakeAppointment = clsTestAppointment.Find(reTakeApplication.ApplicationID);
                lblRetakeAppFees.Text = reTakeApplication.PaidFees.ToString("0");
                if (_appointmentID == -1)
                {
                    lblRetakeTestAppID.Text = "N/A";
                }
                else
                {
                    lblRetakeTestAppID.Text = reTakeAppointment.TestAppointmentID.ToString();
                }
                int TotalFees = Convert.ToInt32(TestTypes.TestTypeFees) + Convert.ToInt32(reTakeApplication.PaidFees);
                lblTotalFees.Text = TotalFees.ToString();
            }
        }

        private void _FillAppointmentData()
        {
            if (Mode == enMode.Add)
            {
                appointment = new clsTestAppointment();
                dtpAppointmentDate.Value = DateTime.Now;
                return;
            }
            appointment = clsTestAppointment.Find(_appointmentID);

            if (appointment.IsLocked == true)
            {
                dtpAppointmentDate.Enabled = false;
                lblTitle.Visible = false;
                lblRetakeTitle.Visible = true;
                lblSubTitle.Text = "Person already sat for this test. Appointment is Locked";
                btnSave.Enabled = false;
            }
            else
            {
                dtpAppointmentDate.Value = appointment.AppointmentDate;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            appointment.LocalDrivingLicenseApplicationID = _localDrivingLicenseAppID;
            appointment.TestTypeID = TestTypes.TestTypeID;
            appointment.PaidFees = TestTypes.TestTypeFees;
            appointment.IsLocked = false;
            appointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            appointment.AppointmentDate = dtpAppointmentDate.Value;
            appointment.RetakeTestApplicationID = _reTakeApplicationID;

            if (appointment.Save())
            {
                MessageBox.Show("Appointment is booked Successfully");
                Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("Appointment is not booked Successfully");
            }

        }
    }
}
