using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class TestAppointmentData
    {
        public static bool Find(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

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
                        TestTypeID = (int)reader["TestTypeID"];
                        LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                        AppointmentDate = (DateTime)reader["AppointmentDate"];
                        PaidFees = (decimal)reader["PaidFees"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                        IsLocked = (bool)reader["IsLocked"];
                        if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        {
                            RetakeTestApplicationID = -1;
                        }
                        else
                        {
                            RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                        }
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

        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID) 
                            VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
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
            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime AppointmentDate, bool IsLocked)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments SET AppointmentDate = @AppointmentDate, IsLocked = @IsLocked WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close(); 
            }
            return rowAffected > 0;
        }

        public static bool CheckPreviousAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID and IsLocked = 0";

            SqlCommand command = new SqlCommand(@query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) 
                {
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

        public static DataTable GetAllAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked FROM TestAppointments
                             WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;
        }

    }
}
