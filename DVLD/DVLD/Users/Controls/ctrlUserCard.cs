using DVLD_Business;
using DVLD.Properties;
using System.Windows.Forms;

namespace DVLD.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserID = -1;

        private clsUser _User;

        public int UserId
        {
            get { return _UserID; }
        }

        public clsUser SelectedUser
        {
            get { return _User; }
        }


        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;

            _User = clsUser.Find(UserID);

            if (_User == null) 
            {
                MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            _UserID = _User.UserID;
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();   
            lblIsActive.Text = _User.IsActive.ToString();
        }

        private void lblEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser(_UserID);
            frmAddUpdateUser.ShowDialog();
            LoadUserInfo(_UserID);
        }
    }
}
