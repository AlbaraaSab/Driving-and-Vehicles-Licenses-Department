using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class CountryData
    {
        public static bool Find(int CountryID, ref string CountryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * From Countries WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        CountryName = reader["CountryName"].ToString();
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

        public static bool Find(string CountryName, ref int CountryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * From Countries WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryID = (int)reader["CountryID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
                isFound = true;
            }
            return isFound;
        }

        static public DataTable GetAllCountries() 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Countries";

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
    }
}
