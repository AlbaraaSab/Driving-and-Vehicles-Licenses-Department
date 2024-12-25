using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Renew_Local_License
{
    public partial class frmRenewLocalDrivingLicenseApplication : DevExpress.XtraEditors.XtraForm
    {
        clsApplicatonTypes applicatonTypes;
        clsLicense License;
        clsLicense RenewLicense;

        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            applicatonTypes = clsApplicatonTypes.FindApplicationType(2);

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblApplicationFees.Text = applicatonTypes.ApplicationFees.ToString("0");
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(clsLicense arg1, int arg2)
        {
            License = arg1;

            if (License == null)
            {
                MessageBox.Show("No License Found", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnShowLicenseHistory.Enabled = true;

            if (License.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("Selected License is not yet expaired, it will expire on : " + clsFormat.DateToShort(License.ExpirationDate), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
            }

            int totalFees = Convert.ToInt32(License.PaidFees) + Convert.ToInt32(applicatonTypes.ApplicationFees);
            
            lblLicenseFees.Text = License.PaidFees.ToString("0");
            lblOldLicenseID.Text = License.LicenseID.ToString();
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(clsLicenseClasses.FindLicenseClasses(License.LicenseClassID).DefaultValidityLength));
            lblTotalFees.Text = totalFees.ToString("0");

        }

        private void btnShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo showLicenseInfo = new frmShowLicenseInfo(RenewLicense.LicenseID);
            showLicenseInfo.ShowDialog();
        }

        private void btnShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory showPersonLicensesHistory = new frmShowPersonLicensesHistory(ctrlLicenseInfoWithFilter1.PersonID);
            showPersonLicensesHistory.ShowDialog();
        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (License == null)
            {
                MessageBox.Show("No Data Found", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to Renew this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsApplication application = new clsApplication();

                application.ApplicantPersonID = ctrlLicenseInfoWithFilter1.PersonID;
                application.ApplicationDate = DateTime.Now;
                application.ApplicationTypeID = 2;
                application.ApplicationStatus = 3;
                application.LastStatusDate = DateTime.Now;
                application.PaidFees = applicatonTypes.ApplicationFees;
                application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                application.Save();

                RenewLicense = new clsLicense();

                RenewLicense.ApplicationID = License.ApplicationID;
                RenewLicense.DriverID = License.DriverID;
                RenewLicense.LicenseClassID = License.LicenseClassID;
                RenewLicense.IssueDate = DateTime.Now;
                RenewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses.FindLicenseClasses(License.LicenseClassID).DefaultValidityLength);
                RenewLicense.Notes = txtNotes.Text;
                RenewLicense.PaidFees = License.PaidFees;
                RenewLicense.IsActive = true;
                RenewLicense.IssueReason = 2;
                RenewLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                License.IsActive = false;

                License.DeactivateLicense();

                if (RenewLicense.IssueLicense())
                {
                    MessageBox.Show("License Renewed Successfully with ID = " + RenewLicense.LicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnShowNewLicenseInfo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblRenewApplicationID.Text = application.ApplicationID.ToString();
                lblRenewLicenseID.Text = RenewLicense.LicenseID.ToString();
            }
            else
            {
                MessageBox.Show("Renew Operation is Cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
