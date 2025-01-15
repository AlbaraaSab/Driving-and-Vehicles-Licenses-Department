using DVLD_Business;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System;

namespace DVLD.Global_Classes
{
    public class clsGlobal
    {
        public static clsUser CurrentUser { get; set; }
        
        public static bool StoreUserNameAndPasswordToFile(string Username, string Password)
        {
            try
            {
                //this will get the current project directory folder.
                string currentDirectory = Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = Username + "#//#" + Password;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredentialFromFile(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath = currentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool StoreUserNameAndPasswordToRegistry(string userName, string password)
        {
            bool isStored = false;
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

            try
            {
                Registry.SetValue(KeyPath, "USER_NAME", userName, RegistryValueKind.String);
                Registry.SetValue(KeyPath, "PASSWORD", password, RegistryValueKind.String);
                isStored = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isStored;
        }

        public static bool GetStoredCredentialFromRegistry(ref string username, ref string password)
        {
            bool isFound = false;

            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

            try
            {
                username = (string)Registry.GetValue(KeyPath, "USER_NAME", null);
                password = (string)Registry.GetValue(KeyPath, "PASSWORD", null);
                isFound = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isFound;
        }

    }
}
