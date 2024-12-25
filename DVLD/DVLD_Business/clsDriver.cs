using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }


        public clsDriver() 
        {
            DriverID = 0;
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.Now;
        }

        public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            PersonInfo = clsPerson.FindPerson(PersonID);
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }

        public static bool IsPersonADriver(int PersonID)
        {
            return DriverData.IsPersonADriver(PersonID);
        }

        public static clsDriver FindDriver(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (DriverData.FindByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            return null;
        }

        public void AddNewDriver()
        {
            DriverID = DriverData.AddNewDriver(PersonID, CreatedByUserID, CreatedDate);
        }

        public static DataTable LoadAllDrivers()
        {
            return DriverData.GetAllDrivers();
        }

    }
}
