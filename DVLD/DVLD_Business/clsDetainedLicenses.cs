
using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsDetainedLicenses
    {
        public int DetainID { get; set; }
        public int LicensesID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public clsDetainedLicenses()
        {
            DetainID = 0;
            LicensesID = 0;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = 0;
            IsReleased = false;
            ReleaseDate = DateTime.Now;
            ReleasedByUserID = 0;
            ReleaseApplicationID = 0;
        }

        private clsDetainedLicenses(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicensesID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
        }


        public static clsDetainedLicenses Find(int LicenseID)
        {
            int DetainID = 0;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0;
            int CreatedByUserID = 0;
            bool IsReleased = false;
            DateTime? ReleaseDate = DateTime.Now;
            int? ReleasedByUserID = 0;
            int? ReleaseApplicationID = 0;

            if (DetainedLicenseData.Find(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID); 
            }
            return null;
        }


        public bool DetainLicense()
        {
            DetainID = DetainedLicenseData.AddNewDetainedLicense(LicensesID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            return (DetainID != -1);
        }

        public bool ReleaseDetainedLicense(int LicenseID)
        {
            return DetainedLicenseData.UpdateDetainedLicense(LicenseID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
        }

        public static bool IsDetained(int LicenseID)
        {
            return DetainedLicenseData.IsDetained(LicenseID);
        }

        public static DataTable ListDetainedLicenses()
        {
            return DetainedLicenseData.GetAllDetainedLicense();
        }

    }
}
