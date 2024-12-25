using DVLD.Global_Classes;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_Licenses
{
    public partial class frmIssueDriverLicenseFirstTime : DevExpress.XtraEditors.XtraForm
    {

        int LocalDrivingLicenseApplicationID;

        public frmIssueDriverLicenseFirstTime(int LocalDrivingLicenseApplicationID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            InitializeComponent();
        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLocalApplicatoinInfo1.LoadApplicationData(LocalDrivingLicenseApplicationID);
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            clsLicense license = new clsLicense();
            clsDriver Driver = new clsDriver();

            clsLocalDrivingLicenseApplications localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID(LocalDrivingLicenseApplicationID);

            if (!clsDriver.IsPersonADriver(localDrivingLicenseApplications.ApplicantPersonID))
            {
                Driver.PersonID = localDrivingLicenseApplications.ApplicantPersonID;
                Driver.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                Driver.CreatedDate = DateTime.Now;
                Driver.AddNewDriver();
            }

            license.ApplicationID = localDrivingLicenseApplications.ApplicationID;
            license.DriverID = Driver.DriverID;
            license.LicenseClassID = localDrivingLicenseApplications.LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(localDrivingLicenseApplications.LicenseClassInfo.DefaultValidityLength);
            license.Notes = txtNotes.Text;
            license.PaidFees = localDrivingLicenseApplications.LicenseClassInfo.ClassFees;
            license.IsActive = true;
            license.IssueReason = 1;
            license.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (license.IssueLicense())
            {
                ctrlLocalApplicatoinInfo1.LicenseID = license.LicenseID;
                localDrivingLicenseApplications.ApplicationStatus = 3;
                localDrivingLicenseApplications.LastStatusDate = DateTime.Now;
                localDrivingLicenseApplications.Save();
                MessageBox.Show("License has been Issued Successfully with ID = " + license.LicenseID.ToString() + ".", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
