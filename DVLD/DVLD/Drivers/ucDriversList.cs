using DVLD_Business;

namespace DVLD.Drivers
{
    public partial class ucDriversList : DevExpress.DXperience.Demos.TutorialControlBase //UserControl
    {
        public ucDriversList()
        {
            InitializeComponent();
        }

        private void _ReloadDriversData()
        {
            dgvDrivers.DataSource = clsDriver.LoadAllDrivers();
            gridView1.OptionsBehavior.ReadOnly = true;
            DriversRecords.Caption = gridView1.RowCount.ToString();
        }

        private void ucDriversList_Load(object sender, System.EventArgs e)
        {
            _ReloadDriversData();
        }
    }
}
