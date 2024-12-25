using DVLD.Licenses;
using DVLD.People;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD.Applications.Controls
{
    public partial class ctrlLocalApplicatoinInfo : UserControl
    {

        clsLocalDrivingLicenseApplications _localDrivingLicenseApplications;

        public int LicenseID;
        
        public ctrlLocalApplicatoinInfo()
        { 
            InitializeComponent();
        }

        public void LoadApplicationData(int localDrivingLicenseID)
        {
            _localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID(localDrivingLicenseID);

            if (_localDrivingLicenseApplications == null)
            {
                MessageBox.Show("No Local Application with LocalDrivingLicenseApplicationID = " + localDrivingLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalApplictionData();         
        }

        private void _FillLocalApplictionData()
        {
            int PassedTest = clsLocalDrivingLicenseApplications.NumberOfPassedTest(_localDrivingLicenseApplications.LocalDrivingLicenseApplicationID);

            lblDrivingLocalAppID.Text = _localDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();

            lblLicenseClass.Text = _localDrivingLicenseApplications.LicenseClassInfo.ClassName;


            if (PassedTest == 0)
            {
                lblPassedTests.Text = "0/3";
            }
            else if (PassedTest == 1)
            {
                lblPassedTests.Text = "1/3";
            }
            else if (PassedTest == 2)
            {
                lblPassedTests.Text = "2/3";
            }
            else
            {
                lblPassedTests.Text = "3/3";
            }

            lblAppID.Text = _localDrivingLicenseApplications.ApplicationID.ToString();

            if (_localDrivingLicenseApplications.ApplicationStatus == 1)
            {
                lblAppStatus.Text = "New";
            }
            else if (_localDrivingLicenseApplications.ApplicationStatus == 2)
            {
                lblAppStatus.Text = "Cancelled";
            }
            else
            {
                lblAppStatus.Text = "Completed";
                clsLicense license = clsLicense.FindByApplicationID(_localDrivingLicenseApplications.ApplicationID);
                LicenseID = license.LicenseID;
                btnShowLicenseInfo.Enabled = true;
            }

            lblFees.Text = _localDrivingLicenseApplications.PaidFees.ToString("0");
            lblAppTypes.Text = _localDrivingLicenseApplications.ApplicatonTypeInfo.ApplicationTypeTitle;
            lblApplicant.Text = _localDrivingLicenseApplications.PersonInfo.FullName;
            lblAppDate.Text = _localDrivingLicenseApplications.ApplicationDate.ToString();
            lblStatusDate.Text = _localDrivingLicenseApplications.LastStatusDate.ToString();
            lblCreatedBy.Text = _localDrivingLicenseApplications.CreatorUserInfo.UserName;
        }


        private void btnViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo(_localDrivingLicenseApplications.ApplicantPersonID);
            frmShowPersonInfo.ShowDialog();
            _FillLocalApplictionData();
        }

        private void btnShowLicenseInfo_Click(object sender, System.EventArgs e)
        {
            frmShowLicenseInfo showLicenseInfo = new frmShowLicenseInfo(LicenseID);
            showLicenseInfo.ShowDialog();
        }
    }
}
