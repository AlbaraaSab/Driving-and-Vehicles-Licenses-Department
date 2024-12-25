using DVLD.Global_Classes;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }        

        private void btnExistApp_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            clsUser user = clsUser.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user == null)
            {
                MessageBox.Show("Invalid UserName/Password");
                return;
            }
            else
            {
                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {                 
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (user.IsActive == false)
                {
                    MessageBox.Show("User is not Active.\n Ask your manager to activate your account.");
                    return;
                }
                clsGlobal.CurrentUser = user;
                 this.Hide();
                 Form1 frm = new Form1(this);
                 frm.ShowDialog();
                 this.Show();
            }
        }

        private void frmLogin_Load(object sender, System.EventArgs e)
        {

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;
                this.ActiveControl = txtUserName;
            }
        }
    }
}
