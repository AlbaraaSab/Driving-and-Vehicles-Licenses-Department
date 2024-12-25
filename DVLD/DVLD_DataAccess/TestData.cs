using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class TestData
    {
        public static bool FindByTestID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        TestAppointmentID = (int)reader["TestAppointmentID"];
                        TestResult = (bool)reader["TestResult"];
                        Notes = (string)reader["Notes"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                    }
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool FindByAppointmentID(int TestAppointmentID, ref int TestID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        TestID = (int)reader["TestID"];
                        TestResult = (bool)reader["TestResult"];
                        Notes = (string)reader["Notes"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                    }
                   isFound = true;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) 
                            VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes == "")
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
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
            return TestID;
        }

        public static bool isTestPassed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isPassed = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT TestAppointments.TestAppointmentID, LocalDrivingLicenseApplicationID, TestTypeID, TestResult FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID and TestResult = 1;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isPassed = true;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return isPassed;
        }

        public static bool isTestFailed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isFailed = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT TestAppointments.TestAppointmentID, LocalDrivingLicenseApplicationID, TestTypeID, TestResult FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID and TestResult = 0;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFailed = true;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return isFailed;
        }


        public static int TrailTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int Trail = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT COUNT(*) as TestTrail, LocalDrivingLicenseApplicationID FROM
                            (
                                SELECT TestAppointments.TestAppointmentID, LocalDrivingLicenseApplicationID, TestTypeID, TestID, TestResult From TestAppointments
                                INNER JOIN Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID and TestResult = 0
                            ) as R1
                            GROUP BY LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    Trail = Count;
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
            return Trail;
        }

    }
}
