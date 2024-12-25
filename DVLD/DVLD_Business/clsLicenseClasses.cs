using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLicenseClasses
    {

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private clsLicenseClasses(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAgem, byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public static clsLicenseClasses FindLicenseClasses(int LicenseClassID)
        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if (LicenseClassesData.Find(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            return null;

        }

        public static clsLicenseClasses FindLicenseClasses(string ClassName)
        {
            int LicenseClassID = 0;
            string ClassDescription = string.Empty;
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if (LicenseClassesData.Find(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            return null;

        }

        public static DataTable LoadLicenseClasses()
        {
            return LicenseClassesData.GetAllLicenseClasses();
        }

        public bool UpdateLicenseClasses()
        {
            return LicenseClassesData.UpdateLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
        }

    }
}
