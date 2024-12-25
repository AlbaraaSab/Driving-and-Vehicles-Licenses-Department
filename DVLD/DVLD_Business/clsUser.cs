using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsUser
    {
        enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        enMode Mode;

        public clsUser() 
        {
            UserID = -1;
            PersonID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            PersonInfo = clsPerson.FindPerson(personID);
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = UserData.AddNewUser(PersonID, UserName, Password, IsActive);
            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
            return UserData.UpdateUser(UserID, UserName, Password, IsActive);
        }

        public static clsUser Find(int userID) 
        {
            int personID = 0;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;

            if (UserData.Find(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                {
                    if (_AddNewUser())
                        Mode = enMode.Update;
                        return true;
                }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool DeleteUser(int userID)
        {
            return UserData.DeleteUser(userID);
        }

        public static bool IsUserExist(int personId)
        {
            return UserData.IsUserExist(personId);
        }

        public static bool IsUserExistByUserName(string UserName)
        {
            return UserData.IsUserExistByUserName(UserName);
        }

        public static DataTable LoadAllUsers() 
        {
           return UserData.GetAllUsers();
        }

        public static clsUser Login(string username, string password)
        {
            int UserId = 0;
            int PersonId = 0;
            bool isActive = false;

            if (UserData.FindByUserNameAndPassword(username, password, ref UserId, ref PersonId, ref isActive))
            {
                    return new clsUser(UserId, PersonId, username, password, isActive);
            }
            else
            {
                return null;
            }
        }
    }
}
