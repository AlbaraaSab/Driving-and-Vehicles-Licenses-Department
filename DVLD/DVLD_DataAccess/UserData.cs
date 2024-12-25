using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class UserData
    {

        public static bool Find(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read()) 
                    {
                        PersonID = (int)reader["PersonID"];
                        UserName = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        isActive = (bool)reader["isActive"];
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

        public static bool FindByUserNameAndPassword(string UserName, string Password, ref int UserID, ref int PersonID, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserName = @UserName and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        UserID = (int)reader["UserID"];
                        PersonID = (int)reader["PersonID"];
                        isActive = (bool)reader["isActive"];
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

        public static int AddNewUser(int PersonID, string UserName, string Password, bool isActive)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive) VALUES (@PersonID, @UserName, @Password, @IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@isActive", isActive);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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
            return UserID;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            int rowsAffected = -1;

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);

            string query = @"UPDATE Users SET UserName = @UserName, Password = @Password, IsActive = @IsActive WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                connection.Close(); 
            }
            return (rowsAffected != -1);
        }

        public static bool DeleteUser(int UserID) 
        {
            int rowsAffect = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();

                rowsAffect = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffect != -1);
        }

        public static DataTable GetAllUsers()
        {
            DataTable result = new DataTable();

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);

            string query = @"SELECT UserID as [USER ID], Users.PersonID as [Person ID], [FULL NAME] = FirstName + ' ' + SecondName + ' ' + ISNULL(ThirdName,'') + ' ' + LastName, UserName as [User_Name], IsActive as [Is Active] from Users
                             INNER JOIN People ON Users.PersonID = People.PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) 
                {
                    result.Load(reader);
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
            return result;
        }

        public static bool IsUserExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) 
                {
                    isFound = false;
                }
                else
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

        public static bool IsUserExistByUserName(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    isFound = false;
                }
                else
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
