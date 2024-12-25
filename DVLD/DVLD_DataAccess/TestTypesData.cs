using System;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class TestTypesData
    {
        public static bool Find(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        TestTypeTitle = reader["TestTypeTitle"].ToString();
                        TestTypeDescription = reader["TestTypeDescription"].ToString();
                        TestTypeFees = (decimal)reader["TestTypeFees"];
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

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestTypes";

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

        public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int rowAffected = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE TestTypes SET TestTypeFees = @TestTypeFees, TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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
