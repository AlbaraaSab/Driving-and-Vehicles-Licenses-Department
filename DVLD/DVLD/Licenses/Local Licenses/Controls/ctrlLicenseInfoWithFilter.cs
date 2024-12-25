using DVLD.Global_Classes;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_Licenses.Controls
{
    public partial class ctrlLicenseInfoWithFilter : UserControl
    {

        public event Action<clsLicense, int> OnLicenseSelected;
        
        protected virtual void LicenseSelected(clsLicense license, int personID = 0)
        {
            Action<clsLicense, int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(license, personID); 
            }
        }

        public clsLicense License { get; set; }
        public int PersonID { get; set; }


        public ctrlLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            License = clsLicense.Find(Convert.ToInt32(txtLicenseID.Text));

            if (License == null) 
            {
                MessageBox.Show("ID is not Correct. Try again.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLicenseClasses LicenseClasses = clsLicenseClasses.FindLicenseClasses(License.LicenseClassID);
            clsApplication Application = clsApplication.Find(License.ApplicationID);
            clsPerson Person = clsPerson.FindPerson(Application.ApplicantPersonID);


            PersonID = Person.PersonID;

            string ApplicantFullName = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;

            lblLicenseClass.Text = LicenseClasses.ClassName;
            lblPersonName.Text = ApplicantFullName;
            lblLicenseID.Text = License.LicenseID.ToString();
            lblNationalNo.Text = Person.NationalNo.ToString();
            if (Person.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }
            lblIssueDate.Text = clsFormat.DateToShort(License.IssueDate);
            if (License.IssueReason == 1)
            {
                lblIssueReason.Text = "First Time";
            }
            else if (License.IssueReason == 2)
            {
                lblIssueReason.Text = "Renew";
            }
            else if (License.IssueReason == 3)
            {
                lblIssueReason.Text = "Replacement for Damaged";
            }
            else if (License.IssueReason == 4)
            {
                lblIssueReason.Text = "Replacement for Lost";
            }

            lblNotes.Text = License.Notes.ToString();

            if (License.IsActive == true)
            {
                lblIsActive.Text = "YES";
            }
            else
            {
                lblIsActive.Text = "NO";
            }
            lblDateOfBirth.Text = clsFormat.DateToShort(Person.DateOfBirth);

            lblDriverID.Text = License.DriverID.ToString();

            lblExpirationDate.Text = clsFormat.DateToShort(License.ExpirationDate);

            if (clsDetainedLicenses.IsDetained(License.LicenseID))
            {
                lblIsDetained.Text = "YES";
            }
            else
            {
                lblIsDetained.Text = "NO";
            }

            pbPersonImage.ImageLocation = Person.ImagePath;

            if (OnLicenseSelected != null)
            {
                OnLicenseSelected(License, PersonID);
            }

        }
    }
}
