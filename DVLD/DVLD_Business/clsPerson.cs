using System;
using System.Data;
using System.Xml.Linq;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        enum enMode { AddNew = 1, Update = 2 }

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public clsCountry Country { get; set; }
        public string ImagePath { get; set; }
        enMode Mode;


        public clsPerson()
        {
            PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Gender = -1;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = -1;
            ImagePath = string.Empty;
            Mode = enMode.AddNew;
        }

        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, int gendor, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            FullName = firstName + " " + secondName + " " + thirdName + " " + lastName;
            DateOfBirth = dateOfBirth;
            Gender = gendor;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            Country = clsCountry.FindCountry(NationalityCountryID);
            ImagePath = imagePath;
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = PersonData.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return PersonData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        static public clsPerson FindPerson(string NationalNo)
        {
            int personID = 0;
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            int gender = 0;
            string address = "";
            string phone = "";
            string email = "";
            int nationalityCountryID = 0;
            string imagePath = "";

            if (PersonData.Find(NationalNo, ref personID, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
                return new clsPerson(personID, NationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, gender, address, phone, email, nationalityCountryID, imagePath);
            else
                return null;
        }

        static public clsPerson FindPerson(int PersonID)
        {
            string NationalNo = "";
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            int gender = 0;
            string address = "";
            string phone = "";
            string email = "";
            int nationalityCountryID = 0;
            string imagePath = "";

            if (PersonData.Find(PersonID, ref NationalNo, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
                return new clsPerson(PersonID, NationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, gender, address, phone, email, nationalityCountryID, imagePath);
            else
                return null;
        }

        static public DataTable LoadAllPeople()
        {
            return PersonData.GetAllPeople();
        }

        static public bool IsPersonExist(string NationalNo)
        {
            return PersonData.isPersonExist(NationalNo);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                {
                        if (_AddNewPerson())
                        {
                            Mode = enMode.AddNew;
                            return true;
                        }
                        else
                            return false;
                }
                case enMode.Update:
                   return _UpdatePerson();
            }
            return false;
        }

        static public bool DeletePerson(int personID)
        {
            if(PersonData.DeletePerson(personID))
                return true;
            else
                return false;
        }

    }
}
