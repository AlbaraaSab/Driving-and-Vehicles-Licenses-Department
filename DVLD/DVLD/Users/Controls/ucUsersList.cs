using System;
using System.Data;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Users.Controls
{
    public partial class ucUsersList : DevExpress.DXperience.Demos.TutorialControlBase //System.Windows.Forms.UserControl 
    {
        public ucUsersList()
        {
            InitializeComponent();
        }

        private void _RefreshUsersGridView()
        {
            dgvUsers.DataSource = clsUser.LoadAllUsers();
            gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void ucUsersList_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            _RefreshUsersGridView();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtUsers = new DataTable();
            dtUsers = clsUser.LoadAllUsers();

            DataView UserView = dtUsers.DefaultView;

            if (comboBox1.SelectedIndex == 1)
            {
                UserView.RowFilter = "IsActive = 'true'";

                dgvUsers.DataSource = UserView;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                UserView.RowFilter = "IsActive = 'false'";
            }
            else
            {
                dgvUsers.DataSource = UserView;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                txtFilter.Visible = true;
                comboBox1.Visible = false;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
                txtFilter.Visible = false;
                comboBox1.Visible = true;
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text != string.Empty)
            {
                DataTable dtUsers = new DataTable();
                dtUsers = clsUser.LoadAllUsers();

                DataView UserView = dtUsers.DefaultView;

                UserView.RowFilter = "UserName = '" + txtFilter.Text + "'";

                if (UserView.Count == 0)
                {
                    MessageBox.Show("User is not found");
                }
                else
                {
                    dgvUsers.DataSource = UserView;
                }

            }
            else
            {
                _RefreshUsersGridView();
            }
        }

        private void btnAddNewUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddUpdateUser addUpdateUser = new frmAddUpdateUser();
            addUpdateUser.ShowDialog();
        }

        private void cmShowUserInfo_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            frmShowUserInfo showUserInfo = new frmShowUserInfo((int)CellValue);
            showUserInfo.ShowDialog();
            _RefreshUsersGridView();
        }

        private void cmUpdate_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            frmAddUpdateUser addUpdateUser = new frmAddUpdateUser((int)CellValue);
            addUpdateUser.ShowDialog();
            _RefreshUsersGridView();
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }

            if (clsUser.DeleteUser((int)CellValue))
            {
                MessageBox.Show("User Deleted Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _RefreshUsersGridView();
        }

        private void cmPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming Service...");
        }

        private void cmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming Service...");
        }

        private void cmChangePassword_Click(object sender, EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                }
            }
            frmChangeUserPassword changeUserPassword = new frmChangeUserPassword((int)CellValue);
            changeUserPassword.ShowDialog();
            _RefreshUsersGridView();
        }
    }
}
