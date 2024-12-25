using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Release_Detained_License
{
    public partial class frmReleaseDetainedLicenseApplication : DevExpress.XtraEditors.XtraForm
    {
        clsLicense License;
        clsDetainedLicenses DetainedLicense;
        clsApplication Application;
        clsApplicatonTypes ApplicationTypes;

        int PersonID;

        public frmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(clsLicense arg1, int arg2)
        {
            License = arg1;
            PersonID = arg2;

            if (License == null)
            {
                MessageBox.Show("No License Found", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReleaseLicense.Enabled = false;
                return;
            }
            btnShowLicenseHistory.Enabled = true;
            lblLicenseID.Text = License.LicenseID.ToString();


            if (!clsDetainedLicenses.IsDetained(License.LicenseID))
            {
                MessageBox.Show("Selected License is not detained. Chooes another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReleaseLicense.Enabled = false;
                return;
            }
            
            DetainedLicense = clsDetainedLicenses.Find(License.LicenseID);

            lblDetainID.Text = DetainedLicense.DetainID.ToString();
            lblDetainDate.Text = clsFormat.DateToShort(DetainedLicense.DetainDate);
            lblLicenseID.Text = License.LicenseID.ToString();
            lblFineFees.Text = DetainedLicense.FineFees.ToString("0");

            int totalFees = Convert.ToInt32(ApplicationTypes.ApplicationFees) + Convert.ToInt32(DetainedLicense.FineFees);

            lblTotalFees.Text = totalFees.ToString("0");

        }

        private void frmReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {
            ApplicationTypes = clsApplicatonTypes.FindApplicationType(5);
            lblApplicationFees.Text = ApplicationTypes.ApplicationFees.ToString("0");
            lblCreatedByID.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this License?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application = new clsApplication();

                Application.ApplicantPersonID = PersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = 5;
                Application.ApplicationStatus = 3;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = ApplicationTypes.ApplicationFees;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                Application.Save();


                DetainedLicense.IsReleased = true;
                DetainedLicense.ReleaseDate = DateTime.Now;
                DetainedLicense.ReleasedByUserID = clsGlobal.CurrentUser.UserID;
                DetainedLicense.ReleaseApplicationID = Application.ApplicationID;

                if (DetainedLicense.ReleaseDetainedLicense(License.LicenseID))
                {
                    MessageBox.Show("Detained License Released Successfully", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlLicenseInfoWithFilter1.Enabled = false;
                    btnReleaseLicense.Enabled = false;
                    btnShowLicenseInfo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Release Operation is Canceled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo showLicenseInfo = new frmShowLicenseInfo(License.LicenseID);
            showLicenseInfo.ShowDialog();
        }

        private void btnShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory showPersonLicensesHistory = new frmShowPersonLicensesHistory(PersonID);
            showPersonLicensesHistory.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
