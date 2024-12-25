using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class ApplicationData
    {
        public static bool Find(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read()) 
                    {
                        ApplicantPersonID = (int)reader["ApplicantPersonID"];
                        ApplicationDate = (DateTime)reader["ApplicationDate"];
                        ApplicationTypeID = (int)reader["ApplicationTypeID"];
                        ApplicationStatus = (byte)reader["ApplicationStatus"];
                        LastStatusDate = (DateTime)reader["LastStatusDate"];
                        PaidFees = (decimal)reader["PaidFees"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
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
        
        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int applicationID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    applicationID = insertedID;
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
            return applicationID;
        }

        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE Applications SET ApplicantPersonID = @ApplicantPersonID, ApplicationDate = @ApplicationDate, ApplicationTypeID = @ApplicationTypeID, ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate, PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected != 0);
        }
   
        public static bool DeleteApplication(int ApplicationID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);
        }

        public static bool CancelApplication(int ApplicationID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE Applications SET  ApplicationStatus = 2, LastStatusDate = GETDATE() WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected != 0);
        }

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Applications";

            SqlCommand command = new SqlCommand(query, connection);

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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool IsTherePreActiveApplications(int PersonID, int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Applications.ApplicationID, 
	                         Applications.ApplicantPersonID, 
	                         Applications.ApplicationStatus, 
	                         LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, 
	                         LocalDrivingLicenseApplications.ApplicationID,
	                         LocalDrivingLicenseApplications.LicenseClassID FROM 
	                         Applications 
                             INNER JOIN 
                             	   LocalDrivingLicenseApplications 
                             ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE ApplicantPersonID = @PersonID and ApplicationStatus = 1 and LicenseClassID = @LicenseClassID;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;
                }

            }
            catch (Exception ex)
            {
                isFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool IsTherePerviousIssuedLicesnse(int ApplicantPersonID, int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Applications.*, LicenseClassID FROM Applications INNER JOIN LocalDrivingLicenseApplications
                             ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE Applications.ApplicantPersonID = @ApplicantPersonID and LicenseClassID = @LicenseClassID and ApplicationStatus = 3";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isFound = true;
                }

            }
            catch (Exception ex)
            {
                isFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
    }
}
