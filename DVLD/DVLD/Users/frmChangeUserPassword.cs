using DVLD_Business;
using System;
using System.Windows.Forms;



namespace DVLD.Users
{
    public partial class frmChangeUserPassword : DevExpress.XtraEditors.XtraForm
    {
        private clsUser _User;

        public frmChangeUserPassword(int userId)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserInfo(userId);
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtCurrentPassword.Focus();
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _User = ctrlUserCard1.SelectedUser;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to change user password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCurrentPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                PasswordErrorPerovid.SetError(txtCurrentPassword, "Current Password connot by blank");
            }
            else
            {
                PasswordErrorPerovid.SetError(txtCurrentPassword, null);
            }

            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel = true;
                PasswordErrorPerovid.SetError(txtCurrentPassword, "Write the Correct Current Password.");
            }
            else
            {
                PasswordErrorPerovid.SetError(txtCurrentPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                PasswordErrorPerovid.SetError(txtNewPassword, "New Password connot by blank");
            }
            else
            {
                PasswordErrorPerovid.SetError(txtNewPassword, null);
            }

            if (txtNewPassword.Text.Trim() == _User.Password)
            {
                e.Cancel = true;
                PasswordErrorPerovid.SetError(txtCurrentPassword, "New Password Should be different from Current Password!");
            }
            else
            {
                PasswordErrorPerovid.SetError(txtCurrentPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                PasswordErrorPerovid.SetError(txtConfirmPassword, "Confirm Password connot by blank");
            }
            else
            {
                PasswordErrorPerovid.SetError(txtConfirmPassword, null);
            }

            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                PasswordErrorPerovid.SetError(txtConfirmPassword, "Confirm Password Should be identical with New Password");
            }
            else
            {
                PasswordErrorPerovid.SetError(txtConfirmPassword, null);
            }
        }
    }
}
