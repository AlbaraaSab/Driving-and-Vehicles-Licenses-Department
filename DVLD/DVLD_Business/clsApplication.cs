using System;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplication
    {

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3}

        public enum enMode { AddNew = 1, Update = 2 }   

        public int ApplicationID        { get; set; }
        public int ApplicantPersonID    { get; set; }
        public clsPerson PersonInfo     { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID    { get; set; }
        public clsApplicatonTypes ApplicatonTypeInfo { get; set; }
        public byte ApplicationStatus   { get; set; }
        public DateTime LastStatusDate  { get; set; }
        public decimal PaidFees         { get; set; }
        public int CreatedByUserID      { get; set; }
        public clsUser CreatorUserInfo  { get; set; }
        public enApplicationStatus AppStatus;
        public enMode Mode;


        public clsApplication()
        {
            ApplicationID = 0;
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = 0;
            ApplicationStatus = (int)enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }

        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.FindPerson(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicatonTypeInfo = clsApplicatonTypes.FindApplicationType(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatorUserInfo = clsUser.Find(CreatedByUserID);
            Mode = enMode.Update;
            AppStatus = (enApplicationStatus)ApplicationStatus;
        }


        private bool _AddNewApplication()
        {
            ApplicationID = ApplicationData.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return (ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return ApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public static clsApplication Find(int applicationID)
        {
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = 0;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            int CreatedByUserID = 0;

            if(ApplicationData.Find(applicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(applicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                {
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                        return false;
                }
                case enMode.Update:
                    return _UpdateApplication();
            } 
            return false;
            
        }

        public static bool CancelApplication(int ApplicationID)
        {
            if(ApplicationData.CancelApplication(ApplicationID))
            {
                return true;
            }
            return false;
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            if (ApplicationData.DeleteApplication(ApplicationID))
            {
                return true;
            }
            return false;
        }

        public static bool PerActiveApplicationForPerson(int PersonID, int LicenseClassID)
        {
            return ApplicationData.IsTherePreActiveApplications(PersonID, LicenseClassID);
        }

        public static bool PerviousIssuedLicense(int ApplicantPersonID, int LicenseClassID)
        {
            return ApplicationData.IsTherePerviousIssuedLicesnse(ApplicantPersonID, LicenseClassID);
        }
    }
}
