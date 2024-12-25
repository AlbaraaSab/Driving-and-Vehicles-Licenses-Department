using System;
using System.Data;
using System.Windows.Forms;
using DVLD.Global_Classes;
using DVLD_Business;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicensesApplications : DevExpress.XtraEditors.XtraForm
    {
        clsApplicatonTypes applicatonTypes;
        clsLocalDrivingLicenseApplications localDrivingLicenseApplications;

        int LocalDrivingApplicationID;

        enum enMode { Add = 1, Update = 2 }
        enMode Mode;

        public frmAddUpdateLocalDrivingLicensesApplications(int LocalDrivingApplicationID)
        {
            InitializeComponent();

            applicatonTypes = clsApplicatonTypes.FindApplicationType(1);

            if (LocalDrivingApplicationID == -1)
            {
                Mode = enMode.Add;
                this.Text = "New Local Driving License Application";
            }
            else 
            {
                this.LocalDrivingApplicationID = LocalDrivingApplicationID;
                this.Text = "Update Local Driving License Application";
                Mode = enMode.Update;
            }
        }

        private void _FillLicenseClassesInComboBox()
        {
            DataTable dt = clsLicenseClasses.LoadLicenseClasses();

            foreach (DataRow row in dt.Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"]);
            }
            cbLicenseClasses.SelectedIndex = 2;
        }

        private void frmAddUpdateLocalDrivingLicensesApplications_Load(object sender, EventArgs e)
        {
            _FillLicenseClassesInComboBox();
            
        
            if (Mode == enMode.Add)
            {
                localDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
                lblApplicationDate.Text = DateTime.Now.ToString();
                lblApplicationFees.Text = applicatonTypes.ApplicationFees.ToString();
                lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName.ToString();
                return;
            }

            localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingApplicationID(LocalDrivingApplicationID);

            if (localDrivingLicenseApplications == null)
            {
                MessageBox.Show("No Application Found");
                return;
            }
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            ctrlPersonCardWithFilter1.LoadPersonInfo(localDrivingLicenseApplications.ApplicantPersonID);
            lblDLApplicationID.Text = localDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = clsFormat.DateToShort(localDrivingLicenseApplications.ApplicationDate);
            cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString(clsLicenseClasses.FindLicenseClasses(localDrivingLicenseApplications.LicenseClassID).ClassName);
            lblApplicationFees.Text = localDrivingLicenseApplications.PaidFees.ToString("0");
            lblCreatedByUser.Text = clsUser.Find(localDrivingLicenseApplications.CreatedByUserID).UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = clsLicenseClasses.FindLicenseClasses(cbLicenseClasses.Text).LicenseClassID;

            localDrivingLicenseApplications.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID;
            localDrivingLicenseApplications.ApplicationDate = DateTime.Now;
            localDrivingLicenseApplications.ApplicationTypeID = applicatonTypes.ApplicationTypeID;
            localDrivingLicenseApplications.ApplicationStatus = 1;
            localDrivingLicenseApplications.PaidFees = applicatonTypes.ApplicationFees;
            localDrivingLicenseApplications.LastStatusDate = DateTime.Now;
            localDrivingLicenseApplications.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            localDrivingLicenseApplications.LicenseClassID = LicenseClassID;

            if (!clsApplication.PerviousIssuedLicense(localDrivingLicenseApplications.ApplicantPersonID, LicenseClassID))
            {
                if (!clsApplication.PerActiveApplicationForPerson(localDrivingLicenseApplications.ApplicantPersonID, LicenseClassID))
                {
                    if (localDrivingLicenseApplications.Save())
                    {
                        lblDLApplicationID.Text = localDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
                        Mode = enMode.Update;
                        lblLocalDrivingIicenseApplicationTitle.Text = "Update Local Driving License Application";
                        this.Text = "Update Local Driving License Application";
           
                        MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: Data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Person already have a license with the same applied driving license class. Choose different driving license class.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tabApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTabPage = tcApplicationInfo.TabPages[1];
                return;
            }


            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {

                btnSave.Enabled = true;
                tabApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTabPage = tcApplicationInfo.TabPages[1];

            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
