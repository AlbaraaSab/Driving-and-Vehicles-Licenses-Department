using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplicatonTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        private clsApplicatonTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static clsApplicatonTypes FindApplicationType(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = string.Empty;
            decimal ApplicationFees = 0;

            if (ApplicationTypesData.Find(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicatonTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            return null;

        }

        public static DataTable LoadApplicationTypes()
        {
            return ApplicationTypesData.GetAllApplicationTypes();
        }

        public bool UpdateApplicationFees()
        {
            return ApplicationTypesData.UpdateApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
        }

    }
}
