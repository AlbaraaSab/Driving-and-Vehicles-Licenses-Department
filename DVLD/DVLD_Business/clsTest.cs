using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTest
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest() 
        {
            TestID = 0;
            TestAppointmentID = 0;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = 0;
        }

        private clsTest(int testID, int appointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = appointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
        }

        public static clsTest Find(int AppointmentID)
        {
            int TestID = 0;
            bool TestResult = false;
            string Notes = string.Empty;
            int CreatedByUserID = 0;

            if (TestData.FindByAppointmentID(AppointmentID, ref TestID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, AppointmentID, TestResult, Notes, CreatedByUserID);
            }
            return null;
        }

        public int TakeTest()
        {
            return TestID = TestData.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        public static bool IsTestPassed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestData.isTestPassed(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static bool IsTestFailed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestData.isTestFailed(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static int TestTrail(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestData.TrailTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

    }
}
