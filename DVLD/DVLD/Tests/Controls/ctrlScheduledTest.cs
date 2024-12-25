using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Tests.Controls
{
    public partial class ctrlScheduledTest : UserControl
    {
        clsLocalDrivingLicenseApplications localDrivingLicenseApplications;
        clsTestTypes testTypes;
        clsTestAppointment _appointment;

        public clsTestAppointment SelectedAppointment
        {
            get { return _appointment; }
        }

        int _AppointmentID;

        public int AppointmentID
        {
            get { return _AppointmentID; }
        }

        public ctrlScheduledTest()
        {
            InitializeComponent();
        }

        public void LoadAppointmentData(int appointmentID)
        {
            _appointment = clsTestAppointment.Find(appointmentID);
            if (_appointment == null)
            {
                MessageBox.Show("No License with LicenseID = " + appointmentID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _AppointmentID = _appointment.TestAppointmentID;
            _FillAppointmentData();
        }

        private void _FillAppointmentData()
        {
            localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID(_appointment.LocalDrivingLicenseApplicationID);
            testTypes = clsTestTypes.FindTestType(_appointment.TestTypeID);


            int Trail = clsTest.TestTrail(_appointment.LocalDrivingLicenseApplicationID, _appointment.TestTypeID);

            if (testTypes.TestTypeID == 1)
            {
                gbScheduledGroup.Text = testTypes.TestTypeTitle.ToString();
                pbTestPicture.Image = Resources.Vision_512;
            }
            else if (testTypes.TestTypeID == 2)
            {
                gbScheduledGroup.Text = testTypes.TestTypeTitle.ToString();
                pbTestPicture.Image = Resources.Written_Test_512;
            }
            else
            {
                gbScheduledGroup.Text = testTypes.TestTypeTitle.ToString();
                pbTestPicture.Image = Resources.driving_test_512;
            }

            lblDrivingLocalAppID.Text = localDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = localDrivingLicenseApplications.LicenseClassInfo.ClassName;
            lblApplicantName.Text = localDrivingLicenseApplications.PersonInfo.FullName;
            lblTrail.Text = Trail.ToString();
            lblAppointmentDate.Text = _appointment.AppointmentDate.ToString();
            lblFees.Text = testTypes.TestTypeFees.ToString();

        }
    }
}
