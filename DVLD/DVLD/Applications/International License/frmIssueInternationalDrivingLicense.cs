using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD.Licenses.International_Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.International_License
{
    public partial class frmIssueInternationalDrivingLicense : DevExpress.XtraEditors.XtraForm
    {
        clsLicense License;
        clsApplication Application;
        clsInternationalLicense InternationalLicense;
        clsApplicatonTypes ApplicationTypes;
        int PersonID;


        public frmIssueInternationalDrivingLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (clsInternationalLicense.CheckPerviousInternationalLicense(License.LicenseID))
            {
                MessageBox.Show("Person already have an active International License.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (License.IsActive == true && License.LicenseClassID == 3 && License.ExpirationDate >= DateTime.Now)
                {
                    lblLocalLicenseID.Text = License.LicenseID.ToString();

                    if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Application = new clsApplication();

                        Application.ApplicantPersonID = PersonID;
                        Application.ApplicationDate = DateTime.Now;
                        Application.ApplicationTypeID = 6;
                        Application.ApplicationStatus = 3;
                        Application.LastStatusDate = DateTime.Now;
                        Application.PaidFees = ApplicationTypes.ApplicationFees;
                        Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                        Application.Save();

                        InternationalLicense = new clsInternationalLicense();

                        InternationalLicense.ApplicationID = Application.ApplicationID;
                        InternationalLicense.DriverID = License.DriverID;
                        InternationalLicense.IssuedUsingLocalLicenseID = License.LicenseID;
                        InternationalLicense.IssueDate = DateTime.Now;
                        InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
                        InternationalLicense.IsActive = true;
                        InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                        if (InternationalLicense.IssueInternationlLicense())
                        {
                            MessageBox.Show("International License Issued Successfully with ID = " + InternationalLicense.InternationalLicenseID + ".", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            lblApplicationID.Text = Application.ApplicationID.ToString();
                            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
                            lblLocalLicenseID.Text = License.LicenseID.ToString();
                            btnShowLicenseInfo.Enabled = true;
                            btnIssueLicense.Enabled = false;
                            ctrlLicenseInfoWithFilter1.Enabled = false;
                        }
                    }
                }
                else
                {
                    if (License.IsActive == false || License.ExpirationDate < DateTime.Now)
                    {
                        MessageBox.Show("This License is not active. Please Renew it to get an international license.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (License.LicenseClassID != 3)
                    {
                        MessageBox.Show("Local License class should be [Class 3 - Ordinary driving license].", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void frmIssueInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
            ApplicationTypes = clsApplicatonTypes.FindApplicationType(6);
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));
            lblCreatedByID.Text = clsGlobal.CurrentUser.UserName;
            lblFees.Text = ApplicationTypes.ApplicationFees.ToString("0");
        }

        private void btnShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory showPersonLicensesHistory = new frmShowPersonLicensesHistory(PersonID);
            showPersonLicensesHistory.ShowDialog();
        }

        private void btnShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationlLicenseInfo showInternationlLicenseInfo = new frmShowInternationlLicenseInfo(InternationalLicense.InternationalLicenseID, PersonID);
            showInternationlLicenseInfo.ShowDialog();
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(clsLicense arg1, int arg2)
        {
            License = arg1;
            PersonID = arg2;
        }
    }
}
