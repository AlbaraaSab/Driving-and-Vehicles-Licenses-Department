using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class DetainedLicenseData
    {

        public static bool Find(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * From DetainedLicenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        DetainID = (int)reader["DetainID"];   
                        DetainDate = (DateTime)reader["DetainDate"];   
                        FineFees = (decimal)reader["FineFees"];   
                        CreatedByUserID = (int)reader["CreatedByUserID"];   
                        IsReleased = (bool)reader["IsReleased"];
                        ReleaseDate = (DateTime?)reader["ReleaseDate"];
                        if (reader["ReleaseApplicationID"] == DBNull.Value)
                        {
                            ReleaseApplicationID = null;
                        }
                        else
                        {
                            ReleaseApplicationID = (int?)reader["ReleaseApplicationID"];
                        }
                        if (reader["ReleasedByUserID"] == DBNull.Value)
                        {
                            ReleasedByUserID = null;                            
                        }
                        else
                        {
                            ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);
                        }
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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int DetainedLicenseID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) VALUES 
                             (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            
            if (ReleaseDate == null)
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }

            if (ReleasedByUserID == null)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }

            if (ReleaseApplicationID == null)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID)) 
                {
                    DetainedLicenseID = InsertedID;
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
            return DetainedLicenseID;
        }

        public static bool UpdateDetainedLicense(int LicenseID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int affectedRows = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE DetainedLicenses SET IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            try
            {
                connection.Open();

                affectedRows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return affectedRows > 0;
        }

        public static bool IsDetained(int LicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * From DetainedLicenses WHERE LicenseID = @LicenseID and IsReleased = 0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static DataTable GetAllDetainedLicense()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM DetainedLicenses_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close ();
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

    }
}
