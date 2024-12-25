using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class LicenseClassesData
    {
        public static bool Find(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        ClassName = reader["ClassName"].ToString();
                        ClassDescription = reader["ClassDescription"].ToString();
                        MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                        DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                        ClassFees = (decimal)reader["ClassFees"];
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

        public static bool Find(string ClassName, ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        LicenseClassID = (int)reader["LicenseClassID"];
                        ClassDescription = reader["ClassDescription"].ToString();
                        MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                        DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                        ClassFees = (decimal)reader["ClassFees"];
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

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LicenseClasses";

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

        public static bool UpdateLicenseClasses(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE LicenseClasses SET ClassName = @ClassName, ClassDescription = @ClassDescription, MinimumAllowedAge = @MinimumAllowedAge, DefaultValidityLength = @DefaultValidityLength, ClassFees = @ClassFees WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

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
    }
}
