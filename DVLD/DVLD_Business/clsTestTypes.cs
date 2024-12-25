using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }

        private clsTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }

        public static clsTestTypes FindTestType(int TestTypeID)
        {
            string TestTypeTitle = string.Empty;
            string TestTypeDescription = string.Empty;
            decimal TestTypeFees = 0;

            if (TestTypesData.Find(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            return null;
        }

        public static DataTable LoadApplicationTypes()
        {
            return TestTypesData.GetAllTestTypes();
        }

        public bool UpdateTestType()
        {
            return TestTypesData.UpdateTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }
    }
}
