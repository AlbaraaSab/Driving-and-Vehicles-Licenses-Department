
namespace DVLD.Licenses
{
    public partial class frmShowPersonLicensesHistory : DevExpress.XtraEditors.XtraForm
    {
        public frmShowPersonLicensesHistory(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCardWithFilter1.LoadPersonInfo(PersonID);
            ctrlDriverLicenses1.PersonID = PersonID;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
