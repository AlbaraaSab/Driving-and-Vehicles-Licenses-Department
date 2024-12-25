using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DVLD_DataAccess
{
    public class PersonData
    {

        public static bool Find(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * From People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        PersonID = (int)reader["PersonID"];
                        FirstName = reader["FirstName"].ToString();
                        SecondName = reader["SecondName"].ToString();
                        ThirdName = reader["ThirdName"].ToString();
                        LastName = reader["LastName"].ToString();
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                        Gendor = (int)reader["Gendor"];
                        Address = reader["Address"].ToString();
                        Phone = reader["Phone"].ToString();
                        Email = reader["Email"].ToString();
                        NationalityCountryID = (int)reader["NationalityCountryID"];
                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = reader["ImagePath"].ToString();
                        }
                        else
                        {
                            ImagePath = string.Empty;
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

        public static bool Find(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * From People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        NationalNo = reader["NationalNo"].ToString();
                        FirstName = reader["FirstName"].ToString();
                        SecondName = reader["SecondName"].ToString();
                        ThirdName = reader["ThirdName"].ToString();
                        LastName = reader["LastName"].ToString();
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                        Gendor = (byte)reader["Gendor"];
                        Address = reader["Address"].ToString();
                        Phone = reader["Phone"].ToString();
                        Email = reader["Email"].ToString();
                        NationalityCountryID = (int)reader["NationalityCountryID"];
                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = reader["ImagePath"].ToString();
                        }
                        else
                        {
                            ImagePath = string.Empty;
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

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection  connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, \r\nCASE\r\n WHEN Gendor = 0 then 'MALE'\r\n WHEN Gendor = 1 then 'FEMALE'\r\nEND as Gendor, People.Address, Phone, Email, Countries.CountryName, ImagePath\r\nFROM People INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID\r\nORDER BY FirstName";

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

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People
           (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
           VALUES
           (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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
            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE People SET NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, DateOfBirth = 
                             @DateOfBirth, Gendor = @Gendor, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath WHERE PersonID = @PersonID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }

            try
            {
                connection.Open();

                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return (AffectedRows != -1);
        }
        
        public static bool DeletePerson(int PersonID)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"DELETE FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return (AffectedRows != -1);
        }

        public static bool isPersonExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    isFound = true;
                else
                    isFound = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isFound;
        }

    }
}
