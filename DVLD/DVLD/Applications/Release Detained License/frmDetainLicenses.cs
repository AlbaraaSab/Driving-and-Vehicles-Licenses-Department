using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Release_Detained_License
{
    public partial class frmDetainLicenses : DevExpress.XtraEditors.XtraForm
    {
        clsLicense License;
        clsDetainedLicenses DetainedLicense;
        clsApplication Application;
        int PersonID;
        clsApplicatonTypes applicatonTypes;

        public frmDetainLicenses()
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
                btnDetainLicense.Enabled = false;
                return;
            }
            btnShowLicenseHistory.Enabled = true;
            lblLicenseID.Text = License.LicenseID.ToString();


            if (clsDetainedLicenses.IsDetained(License.LicenseID))
            {
                MessageBox.Show("Selected License is already detained. Chooes another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetainLicense.Enabled = false;
                return;
            }

            DetainedLicense = clsDetainedLicenses.Find(License.LicenseID);
        }

        private void frmDetainLicenses_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByID.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DetainedLicense = new clsDetainedLicenses();

                DetainedLicense.LicensesID = License.LicenseID;
                DetainedLicense.DetainDate = DateTime.Now;
                DetainedLicense.FineFees = Convert.ToDecimal(txtFineFees.Text);
                DetainedLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                DetainedLicense.IsReleased = false;
                DetainedLicense.ReleaseDate = null;
                DetainedLicense.ReleasedByUserID = null;
                DetainedLicense.ReleaseApplicationID = null;

                if (DetainedLicense.DetainLicense())
                {
                    lblDetainID.Text = DetainedLicense.DetainID.ToString();
                    MessageBox.Show("License Detained Successfully with ID = " + DetainedLicense.DetainID.ToString(), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlLicenseInfoWithFilter1.Enabled = false;
                    btnDetainLicense.Enabled = false;
                    btnShowLicenseInfo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Detain operation is cancelled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
