using DVLD.Licenses.International_Licenses;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        public int PersonID;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        private void _LoadDriverLicesnses()
        {
            dgvDriverLocalLicenses.DataSource = clsLicense.LoadDriverLocalLicenses(PersonID);
            dgvDriverInterNationalLicenses.DataSource = clsInternationalLicense.LoadDriverInternationlLicense(PersonID);
            LocalGridView.OptionsBehavior.ReadOnly = true;
            InternationalGridView.OptionsBehavior.ReadOnly = true;
        }

        private void ctrlDriverLicenses_Load(object sender, System.EventArgs e)
        {
            _LoadDriverLicesnses();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = LocalGridView.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = LocalGridView.GetRowCellValue(rowHandle, LocalGridView.Columns[0]);
                }
            }

            frmShowLicenseInfo showLicenseInfo = new frmShowLicenseInfo((int)CellValue);
            showLicenseInfo.ShowDialog();
        }

        private void showInternationalLicenseInfoToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            object CellValue = -1;

            int[] selectedRows = InternationalGridView.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    CellValue = InternationalGridView.GetRowCellValue(rowHandle, InternationalGridView.Columns[0]);
                }
            }

            frmShowInternationlLicenseInfo showInternationlLicenseInfo = new frmShowInternationlLicenseInfo((int)CellValue, PersonID);
            showInternationlLicenseInfo.ShowDialog();

        }
    }
}
