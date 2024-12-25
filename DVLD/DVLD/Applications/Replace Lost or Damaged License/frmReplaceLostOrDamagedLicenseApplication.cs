using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Replace_Lost_or_Damaged_License
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : DevExpress.XtraEditors.XtraForm
    {

        clsLicense License;
        clsLicense ReplacedLicense;
        clsApplication Application;
        int PersonID;
        clsApplicatonTypes applicatonTypes;

        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            ReplacedLicense = new clsLicense();
            Application = new clsApplication();

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByID.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(clsLicense arg1, int arg2)
        {
            License = arg1;
            PersonID = arg2;

            if (License == null)
            {
                MessageBox.Show("No License Found", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueLicense.Enabled = false;
                return;
            }
            btnShowLicenseHistory.Enabled = true;

            if (License.IsActive == false)
            {
                MessageBox.Show("Selected License is not Active. Choose an active License", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueLicense.Enabled = false;
                return;
            }
            btnIssueLicense.Enabled = true;

            lblOldLicenseID.Text = License.LicenseID.ToString();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for this License?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                Application.ApplicantPersonID = PersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationStatus = 3;
                Application.LastStatusDate = DateTime.Now;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                Application.Save();

                ReplacedLicense.ApplicationID = Application.ApplicationID;
                ReplacedLicense.DriverID = License.DriverID;
                ReplacedLicense.LicenseClassID = License.LicenseClassID;
                ReplacedLicense.IssueDate = DateTime.Now;
                ReplacedLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses.FindLicenseClasses(License.LicenseClassID).DefaultValidityLength);
                ReplacedLicense.Notes = License.Notes;
                ReplacedLicense.IsActive = true;
                ReplacedLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (ReplacedLicense.IssueLicense())
                {
                    MessageBox.Show("License Replaced Successfully with ID = " + ReplacedLicense.LicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    License.IsActive = false;
                    License.DeactivateLicense();
                    btnShowLicenseInfo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Replacement Operation is Cancelled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            applicatonTypes = clsApplicatonTypes.FindApplicationType(4);
            Application.ApplicationTypeID = 4;
            Application.PaidFees = applicatonTypes.ApplicationFees;
            ReplacedLicense.IssueReason = 3;
            lblApplicationFees.Text = applicatonTypes.ApplicationFees.ToString("0");
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            applicatonTypes = clsApplicatonTypes.FindApplicationType(3);
            Application.ApplicationTypeID = 3;
            Application.PaidFees = applicatonTypes.ApplicationFees;
            ReplacedLicense.IssueReason = 4;
            lblApplicationFees.Text = applicatonTypes.ApplicationFees.ToString("0");
        }

        private void btnShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory showPersonLicensesHistory = new frmShowPersonLicensesHistory(PersonID);
            showPersonLicensesHistory.ShowDialog();
        }

        private void btnShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo showLicenseInfo = new frmShowLicenseInfo(ReplacedLicense.LicenseID);
            showLicenseInfo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
