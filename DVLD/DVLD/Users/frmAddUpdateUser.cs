using DVLD.People.Controls;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmAddUpdateUser : DevExpress.XtraEditors.XtraForm
    {
        public delegate void DataBackEventHandler(object sender, int userId);
        public event DataBackEventHandler DataBack;

        enum enMode { Add = 1 , Update = 2 }
        enMode Mode;
        int _UserID;
        clsUser _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            _UserID = UserID;
        }


        private void _ResetDefualtValues()
        {
            if (Mode == enMode.Add)
            {
                lblAddUpdateTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                tabLoginInfo.PageEnabled = false;

                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblAddUpdateTitle.Text = "Update User Info";
                this.Text = "Update User Info";
                tabLoginInfo.PageEnabled = true;
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = false;

        }

        private void _LoadUserData()
        {
            _User = clsUser.Find(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (Mode == enMode.Update)
            {
                _LoadUserData();
            }
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tabLoginInfo.Enabled = true;
                tcUserInfo.SelectedTabPage = tcUserInfo.TabPages[1];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {

                if (clsUser.IsUserExist(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tabLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTabPage = tcUserInfo.TabPages[1];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;


            if(_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                Mode = enMode.Update;
                lblAddUpdateTitle.Text = "Update User Info";
                this.Text = "Update User Info";
                DataBack?.Invoke(this, _User.UserID);

                MessageBox.Show("Data Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (Mode == enMode.Add)
            {

                if (clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password connot be blank");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }
    }
}
