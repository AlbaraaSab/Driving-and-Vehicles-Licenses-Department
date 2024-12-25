using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int CountryID;
        public string CountryName;

        public clsCountry()
        {
        }

        private clsCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        static public DataTable LoadAllCountries()
        {
            return CountryData.GetAllCountries();
        }

        static public clsCountry FindCountry(int countryID) 
        {
            string countryName = "";

            if (CountryData.Find(countryID, ref countryName)) 
            {
                return new clsCountry(countryID, countryName);
            }
            else
            {
                return null;
            }
        }

        static public clsCountry FindCountry(string countryName)
        {
            int countryID = 0;

            if (CountryData.Find(countryName, ref countryID))
            {
                return new clsCountry(countryID, countryName);
            }
            else
            {
                return null;
            }

        }
    }
}
