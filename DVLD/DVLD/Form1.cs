using DevExpress.DXperience.Demos;
using DVLD.Applications.International_License;
using DVLD.Applications.Local_Driving_License;
using DVLD.Applications.Release_Detained_License;
using DVLD.Applications.Renew_Local_License;
using DVLD.Applications.Replace_Lost_or_Damaged_License;
using DVLD.Global_Classes;
using DVLD.Login;
using DVLD.Users;
using DVLD.Users.Controls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        frmLogin _login;

        public Form1(frmLogin frmLogin)
        {
            InitializeComponent();
            _login = frmLogin;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Caption = clsGlobal.CurrentUser.UserName;
        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                }
            });

        }

        
        private void acNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicensesApplications addUpdateLocalDrivingLicensesApplications = new frmAddUpdateLocalDrivingLicensesApplications(-1);
            addUpdateLocalDrivingLicensesApplications.ShowDialog();
        }

        private void acNewInterDrivingLicense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalDrivingLicense issueInternationalDrivingLicense = new frmIssueInternationalDrivingLicense();
            issueInternationalDrivingLicense.ShowDialog();
        }


        private async void acPeopleMenu_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"People Management";
            if (ModulesInfo.GetItem("ucPeopleList") == null)
                ModulesInfo.Add(new ModuleInfo("ucPeopleList", "DVLD.People.Controls.ucPeopleList"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucPeopleList"));
        }

        private async void acDriversMenu_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"Drivers";
            if (ModulesInfo.GetItem("ucDriversList") == null)
                ModulesInfo.Add(new ModuleInfo("ucDriversList", "DVLD.Drivers.ucDriversList"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucDriversList"));
        }

        private async void acUsersMenu_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"Users Management";
            if (ModulesInfo.GetItem("ucUsersList") == null)
                ModulesInfo.Add(new ModuleInfo("ucUsersList", "DVLD.Users.Controls.ucUsersList"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucUsersList"));
        }

        private async void acManageApplicationTypes_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"Manage Application Types";
            if (ModulesInfo.GetItem("ucApplicationTypes") == null)
                ModulesInfo.Add(new ModuleInfo("ucApplicationTypes", "DVLD.Applications.Application_Types.ucApplicationTypes"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucApplicationTypes"));
        }

        private async void acManageTestTypes_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"Manage Test Types";
            if (ModulesInfo.GetItem("ucTestTypes") == null)
                ModulesInfo.Add(new ModuleInfo("ucTestTypes", "DVLD.Tests.Test_Types.ucTestTypes"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucTestTypes"));
        }


        private async void acLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"Local Driving License Applications";
            if (ModulesInfo.GetItem("ucListLocalDrivingLicenseApplications") == null)
                ModulesInfo.Add(new ModuleInfo("ucListLocalDrivingLicenseApplications", "DVLD.Applications.Local_Driving_License.ucListLocalDrivingLicenseApplications"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucListLocalDrivingLicenseApplications"));
        }

        private async void acInternationalLicenseApplications_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"International Driving License Applications";
            if (ModulesInfo.GetItem("ucListInternationalDrivingLicenseApplications") == null)
                ModulesInfo.Add(new ModuleInfo("ucListInternationalDrivingLicenseApplications", "DVLD.Applications.International_License.ucListInternationalDrivingLicenseApplications"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucListInternationalDrivingLicenseApplications"));
        }


        private async void acManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"Manage Detain Licenses";
            if (ModulesInfo.GetItem("ucListDetainedLicenses") == null)
                ModulesInfo.Add(new ModuleInfo("ucListDetainedLicenses", "DVLD.Applications.Release_Detained_License.ucListDetainedLicenses"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucListDetainedLicenses"));
        }

        private void acCurrentUser_Click(object sender, EventArgs e)
        {
            frmShowUserInfo showUserInfo = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            showUserInfo.ShowDialog();
        }

        private void acChangePassword_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword changeUserPassword = new frmChangeUserPassword(clsGlobal.CurrentUser.UserID);
            changeUserPassword.ShowDialog();
        }

        private void acSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _login.Show();
            this.Close();
        }

        private void acRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication renewLocalDrivingLicenseApplication = new frmRenewLocalDrivingLicenseApplication();
            renewLocalDrivingLicenseApplication.ShowDialog();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication replaceLostOrDamagedLicenseApplication = new frmReplaceLostOrDamagedLicenseApplication();
            replaceLostOrDamagedLicenseApplication.ShowDialog();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication releaseDetainedLicenseApplication = new frmReleaseDetainedLicenseApplication();
            releaseDetainedLicenseApplication.ShowDialog();
        }

        private void acDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicenses detainLicenses = new frmDetainLicenses();
            detainLicenses.ShowDialog();
        }

        private void acReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication releaseDetainedLicenseApplication = new frmReleaseDetainedLicenseApplication();
            releaseDetainedLicenseApplication.ShowDialog();
        }

    }
}
