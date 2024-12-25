
namespace DVLD.Licenses
{
    public partial class frmShowLicenseInfo : DevExpress.XtraEditors.XtraForm
    {
        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            ctrlLicenseInfo1.LoadLicenseData(LicenseID);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        
    }
}
