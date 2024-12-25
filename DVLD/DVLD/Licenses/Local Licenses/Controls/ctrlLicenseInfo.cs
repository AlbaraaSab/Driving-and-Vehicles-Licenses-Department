using DVLD.Global_Classes;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlLicenseInfo : UserControl
    {

        private clsLicense _License;

        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return _License; }
        }

        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadLicenseData(int LicenseID)
        {
            _License = clsLicense.Find(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("No License with LicenseID = " + LicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLicenseInfo();
        }

        private void _FillLicenseInfo()
        {
            lblLicenseClass.Text = _License.LicenseClassInfo.ClassName;
            lblPersonName.Text = _License.ApplicationInfo.PersonInfo.FullName;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _License.ApplicationInfo.PersonInfo.NationalNo;
            if (_License.ApplicationInfo.PersonInfo.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }
            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            if (_License.IssueReason == 1)
            {
                lblIssueReason.Text = "First Time";
            }
            else if (_License.IssueReason == 2)
            {
                lblIssueReason.Text = "Renew";
            }
            else if (_License.IssueReason == 3)
            {
                lblIssueReason.Text = "Replacement for Damaged";
            }
            else if (_License.IssueReason == 4)
            {
                lblIssueReason.Text = "Replacement for Lost";
            }

            lblNotes.Text = _License.Notes.ToString();

            if (_License.IsActive == true)
                lblIsActive.Text = "YES";
            else
                lblIsActive.Text = "NO";

            lblDateOfBirth.Text = clsFormat.DateToShort(_License.ApplicationInfo.PersonInfo.DateOfBirth);

            lblDriverID.Text = _License.DriverID.ToString();

            lblExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);

            if (clsDetainedLicenses.IsDetained(LicenseID))
            {
                lblIsDetained.Text = "YES";
            }
            else
            {
                lblIsDetained.Text = "NO";
            }


            pbPersonImage.ImageLocation = _License.ApplicationInfo.PersonInfo.ImagePath;
        }

    }
}
