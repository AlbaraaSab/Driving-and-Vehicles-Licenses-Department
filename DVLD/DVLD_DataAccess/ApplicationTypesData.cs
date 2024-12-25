using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class ApplicationTypesData
    {

        public static bool Find(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();
                        ApplicationFees = (decimal)reader["ApplicationFees"];
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

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes";

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

        public static bool UpdateApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int rowAffected = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE ApplicationTypes SET ApplicationFees = @ApplicationFees, ApplicationTypeTitle = @ApplicationTypeTitle WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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
            return (rowAffected != -1);
        }
    }
}
