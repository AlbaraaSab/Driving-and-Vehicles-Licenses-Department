using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ucPeopleList : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl  
    {
        public ucPeopleList()
        {
            InitializeComponent();
        }

        private void _RefreshPeopleGridView()
        {
            dgvPeople.DataSource = clsPerson.LoadAllPeople();
            gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void btnAddNewPerson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();
            _RefreshPeopleGridView();
        }

        private void ucPeopleList_Load(object sender, EventArgs e)
        {
            _RefreshPeopleGridView();
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

            frmAddUpdatePerson frmAddUpdate = new frmAddUpdatePerson((int)CellValue);
            frmAddUpdate.ShowDialog();
            _RefreshPeopleGridView();
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

            if (clsPerson.DeletePerson((int)CellValue))
            {
                MessageBox.Show("Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Delete Failed.");
            }
            _RefreshPeopleGridView();
        }

        private void cmShowPersonInfo_Click(object sender, EventArgs e)
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

            frmShowPersonInfo frmShowPerson = new frmShowPersonInfo((int)CellValue);
            frmShowPerson.ShowDialog();
            _RefreshPeopleGridView();
        }

        private void cmPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming Service...");
        }

        private void cmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming Service...");
        }
    }
}
