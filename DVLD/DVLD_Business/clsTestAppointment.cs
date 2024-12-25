using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        enum enMode { Add = 1, Update  = 2 };
        enMode Mode;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        public clsTestAppointment()
        {
            TestAppointmentID = 0;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            RetakeTestApplicationID = -1;
            Mode = enMode.Add;
        }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID= TestAppointmentID;
            this.TestTypeID= TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID= CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            Mode = enMode.Update;
        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = 0;
            int LocalDrivingLicenseApplicationID = 0;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            int CreatedByUserID = 0;
            bool IsLocked = false;
            int RetakeTestApplicationID = 0;

            if (TestAppointmentData.Find(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            return null;
        }

        public static DataTable LoadAppointments(int localDrivingLicenseApplicationID, int testTypeID)
        {
            return TestAppointmentData.GetAllAppointments(localDrivingLicenseApplicationID, testTypeID);
        }

        private bool _AddNewTestAppointment()
        {
            TestAppointmentID = TestAppointmentData.AddNewTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            return TestAppointmentID != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return TestAppointmentData.UpdateTestAppointment(TestAppointmentID, AppointmentDate, IsLocked);
        }

        public bool Save()
        {
            switch(Mode)
            {
                    case enMode.Add:
                    {
                        if(_AddNewTestAppointment())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                    case enMode.Update:
                    {
                        return _UpdateTestAppointment();
                    }
            }
                    return false;
        }

        public static bool CheckPerviousAppointment(int localDrivingLicenseApplicationID, int testTypeID)
        {
            return TestAppointmentData.CheckPreviousAppointment(localDrivingLicenseApplicationID, testTypeID);
        }


    }
}
