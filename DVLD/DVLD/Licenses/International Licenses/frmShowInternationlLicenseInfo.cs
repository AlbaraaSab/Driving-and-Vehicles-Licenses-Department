using DVLD.Global_Classes;
using DVLD_Business;
using System.ComponentModel;

namespace DVLD.Licenses.International_Licenses
{
    public partial class frmShowInternationlLicenseInfo : DevExpress.XtraEditors.XtraForm
    {
        int InternationalLicenseID;
        int PersonID;
        clsPerson Person;
        clsInternationalLicense InternationalLicense;

        public frmShowInternationlLicenseInfo(int InternationalLicenseID, int PersonID)
        {
            InitializeComponent();
            this.InternationalLicenseID = InternationalLicenseID;
            this.PersonID = PersonID;
        }

        private void frmShowInternationlLicenseInfo_Load(object sender, System.EventArgs e)
        {
            Person = clsPerson.FindPerson(PersonID);
            InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID);

            string ApplicantFullName = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;

            lblPersonName.Text = ApplicantFullName;
            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            lblLocalLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = Person.NationalNo.ToString();
            if (Person.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }
            lblIssueDate.Text = clsFormat.DateToShort(InternationalLicense.IssueDate);
            lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();

            if (InternationalLicense.IsActive == true)
                lblIsActive.Text = "YES";
            else
                lblIsActive.Text = "NO";

            lblDateOfBirth.Text = clsFormat.DateToShort(Person.DateOfBirth);
            lblDriverID.Text = InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = clsFormat.DateToShort(InternationalLicense.ExpirationDate);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
