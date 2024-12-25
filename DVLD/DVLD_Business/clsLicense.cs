using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClasses LicenseClassInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
            LicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            LicenseClassID = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = false;
            IssueReason = 0;
            CreatedByUserID = 0;
        }

        private clsLicense(int licenseID, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID)
        {            
            LicenseID = licenseID;
            ApplicationID = applicationID;
            ApplicationInfo = clsApplication.Find(applicationID);
            DriverID = driverID;
            DriverInfo = clsDriver.FindDriver(driverID);
            LicenseClassID = licenseClassID;
            LicenseClassInfo = clsLicenseClasses.FindLicenseClasses(LicenseClassID);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }

        public static clsLicense Find(int LicenseID)
        {
            int applicationID = 0;
            int driverID = 0;
            int licenseClassID = 0;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string notes = string.Empty;
            decimal paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;
            int createdByUserID = 0;


            if (LicenseData.Find(LicenseID, ref applicationID, ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicense(LicenseID, applicationID, driverID, licenseClassID, issueDate, expirationDate, notes, paidFees, isActive, issueReason, createdByUserID);
            }
            return null;
        }

        public static clsLicense FindByApplicationID(int ApplicationID)
        {
            int licenseID = 0;
            int driverID = 0;
            int licenseClassID = 0;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string notes = string.Empty;
            decimal paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;
            int createdByUserID = 0;


            if (LicenseData.FindByApplicationID(ApplicationID, ref licenseID, ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicense(licenseID, ApplicationID, driverID, licenseClassID, issueDate, expirationDate, notes, paidFees, isActive, issueReason, createdByUserID);
            }
            return null;
        }

        public bool IssueLicense()
        {
            LicenseID = LicenseData.AddNewLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            return LicenseID != -1 ? true : false;
        }

        public bool DeactivateLicense()
        {
            return LicenseData.UpdateLicense(LicenseID, IsActive);
        }

        public static DataTable LoadDriverLocalLicenses(int PersonID) 
        {
            return LicenseData.GetAllDriverLocalLicenses(PersonID);
        }

    }
}
