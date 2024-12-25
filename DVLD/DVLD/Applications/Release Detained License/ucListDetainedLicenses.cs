

using DVLD_Business;

namespace DVLD.Applications.Release_Detained_License
{
    public partial class ucListDetainedLicenses : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void _ReloadDataGridView()
        {
            dgvDetainedLicenses.DataSource = clsDetainedLicenses.ListDetainedLicenses();
            gridView1.OptionsBehavior.ReadOnly = true;
            lblRecords.Caption = gridView1.RowCount.ToString();
        }

        private void ucListDetainedLicenses_Load(object sender, System.EventArgs e)
        {
            _ReloadDataGridView();
        }

        private void btnDetainLicense_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDetainLicenses detainLicenses = new frmDetainLicenses();
            detainLicenses.ShowDialog();
        }

        private void btnReleaseLicense_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReleaseDetainedLicenseApplication releaseDetainedLicenseApplication = new frmReleaseDetainedLicenseApplication();
            releaseDetainedLicenseApplication.ShowDialog();
        }
    }
}
