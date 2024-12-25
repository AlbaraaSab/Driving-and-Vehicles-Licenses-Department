using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests.Test_Types
{
    public partial class ucTestTypes : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucTestTypes()
        {
            InitializeComponent();
        }

        private void _ReloadTestTypesData()
        {
            dgvTestTypes.DataSource = clsTestTypes.LoadApplicationTypes();
        }

        private void ucTestTypes_Load(object sender, EventArgs e)
        {
            _ReloadTestTypesData();
        }

        private void cmEditTestType_Click(object sender, EventArgs e)
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
            frmEditTestTypes editTestTypes = new frmEditTestTypes((int)CellValue);
            editTestTypes.ShowDialog();
            _ReloadTestTypesData();
        }
    }
}
