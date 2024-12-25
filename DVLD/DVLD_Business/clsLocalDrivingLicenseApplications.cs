using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplications : clsApplication
    {

        public new enum enMode { Add = 1, Update = 2 }
        public new enMode Mode = enMode.Add;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClasses LicenseClassInfo { get; set; }
        public clsApplicatonTypes ApplicatonTypeInfo { get; set; }
        public new clsPerson PersonInfo { get; set; }
        public new clsUser CreatorUserInfo { get; set; }

        public clsLocalDrivingLicenseApplications()
        {
            LocalDrivingLicenseApplicationID = 0;
            LicenseClassID = 0;
            Mode = enMode.Add;
        }

        private clsLocalDrivingLicenseApplications(int localDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int licenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatorUserInfo = clsUser.Find(CreatedByUserID);
            this.PersonInfo = clsPerson.FindPerson(ApplicantPersonID);
            this.ApplicatonTypeInfo = clsApplicatonTypes.FindApplicationType(ApplicationTypeID);
            LicenseClassID = licenseClassID;
            LicenseClassInfo = clsLicenseClasses.FindLicenseClasses(licenseClassID);
            Mode = enMode.Update;
        }

        public static clsLocalDrivingLicenseApplications FindByLocalDrivingApplicationID(int localDrivingApplicationID)
        {
            int ApplicationID = 0;
            int LicenseClassID = 0;

            if (LocalDrivingLicenseApplicationsData.FindByLocalDrivingApplicationID(localDrivingApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication Application = Find(ApplicationID);

                return new clsLocalDrivingLicenseApplications(localDrivingApplicationID, Application.ApplicationID, Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            return null;
        }

        public static clsLocalDrivingLicenseApplications FindByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = 0;
            int LicenseClassID = 0;

            if (LocalDrivingLicenseApplicationsData.FindByApplicationID(ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID))
            {
                clsApplication Application = clsApplication.Find(ApplicationID);

                return new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, Application.ApplicationID, Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            return null;
        }


        private bool _AddNewLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationsData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            return LocalDrivingLicenseApplicationID != -1;
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return LocalDrivingLicenseApplicationsData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public new bool Save()
        {
            base.Mode = (clsApplication.enMode) Mode;

            if (!base.Save())
            {
                return false;
            }

            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        if (_AddNewLocalDrivingLicenseApplications())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }

                case enMode.Update:
                    {
                        return _UpdateLocalDrivingLicenseApplication();
                    }
            }
            return false;
        }

        public static DataTable LoadAllLocalDrivingLicenseApplications()
        {
            return LocalDrivingLicenseApplicationsData.GetLocalDrivingLicenseApplications();
        }

        public static int NumberOfPassedTest(int LocalLicenseID)
        {
            return LocalDrivingLicenseApplicationsData.PassedTestsCount(LocalLicenseID);
        }
    }
}
