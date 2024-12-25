using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class InternationalLicenseData
    {

        public static bool Find(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate,  ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ApplicationID = (int)reader["ApplicationID"];
                        DriverID = (int)reader["DriverID"];
                        IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                        IssueDate = (DateTime)reader["IssueDate"];
                        ExpirationDate = (DateTime)reader["ExpirationDate"];
                        IsActive = (bool)reader["IsActive"];
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

        public static int AddNewInterNationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
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
            return InternationalLicenseID;
        }

        public static DataTable GetAllDriverInternationalLicenses(int PersonID)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT InternationalLicenseID, InternationalLicenses.ApplicationID, IssuedUsingLocalLicenseID as [Local License ID], InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive FROM InternationalLicenses
                             INNER JOIN Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID
                             INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID
                             WHERE Drivers.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
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

            return table;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT InternationalLicenseID as [Int.License ID], ApplicationID, DriverID, IssuedUsingLocalLicenseID as [L.License ID], IssueDate, ExpirationDate, IsActive FROM InternationalLicenses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
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

            return table;
        }

        public static bool CheckPerviousInternationalLicense(int IssuedUsingLocalLicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID and IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
           
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
    }
}
