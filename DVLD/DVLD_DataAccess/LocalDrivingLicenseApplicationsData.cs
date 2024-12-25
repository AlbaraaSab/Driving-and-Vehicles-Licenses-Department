using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class LocalDrivingLicenseApplicationsData
    {
        public static bool FindByLocalDrivingApplicationID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read()) 
                    {
                        ApplicationID = (int)reader["ApplicationID"];
                        LicenseClassID = (int)reader["LicenseClassID"];
                    }
                isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool FindByApplicationID(int ApplicationID, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                        LicenseClassID = (int)reader["LicenseClassID"];
                    }
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LDLAppID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) 
                {
                    LDLAppID = insertedID;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                connection.Close();
            }
            return LDLAppID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Update  LocalDrivingLicenseApplications  
                            set ApplicationID = @ApplicationID,
                                LicenseClassID = @LicenseClassID
                            where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetLocalDrivingLicenseApplications()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static int PassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            int PassedTest = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Count(*) as PassedTests , LocalDrivingLicenseApplicationID From (
                             SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, TestAppointments.TestAppointmentID, Tests.TestID, Tests.TestResult
                             FROM TestAppointments 
                             INNER JOIN LocalDrivingLicenseApplications 
                             ON 
                             	  TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                             INNER JOIN Tests 
                             ON 
                             	TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             	WHERE TestResult  = 1
                             	) as R1
                             Group BY LocalDrivingLicenseApplicationID
                             Having R1.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    PassedTest = count;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return PassedTest;
        }

    }

}
