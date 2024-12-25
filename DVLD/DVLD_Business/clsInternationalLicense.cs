
using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense() 
        {
            InternationalLicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            IssuedUsingLocalLicenseID = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = true;
            CreatedByUserID = 0;
        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        { 
            int ApplicationID = 0;
            int DriverID = 0;
            int IssuedUsingLocalLicenseID = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = 0;

            if (InternationalLicenseData.Find(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            return null;
        }

        public bool IssueInternationlLicense()
        {
            InternationalLicenseID = InternationalLicenseData.AddNewInterNationalLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            return (InternationalLicenseID != -1);
        }

        public static DataTable LoadDriverInternationlLicense(int PersonID)
        {
            return InternationalLicenseData.GetAllDriverInternationalLicenses(PersonID);
        }

        public static DataTable GetAllInternationalDrivingLicesnes()
        {
            return InternationalLicenseData.GetAllInternationalLicenses();
        }

        public static bool CheckPerviousInternationalLicense(int IssuedUsingLocalLicenseID)
        {
            return InternationalLicenseData.CheckPerviousInternationalLicense(IssuedUsingLocalLicenseID);
        }
    }
}
