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

namespace DVLD.Applications.Application_Types
{
    public partial class ucApplicationTypes : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucApplicationTypes()
        {
            InitializeComponent();
        }

        private void _ReloadGridViewData()
        {
            dgvApplicationTypes.DataSource = clsApplicatonTypes.LoadApplicationTypes();
        }

        private void ucApplicationTypes_Load(object sender, EventArgs e)
        {
            _ReloadGridViewData();
        }

        private void cmEditApplicationType_Click(object sender, EventArgs e)
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
            frmUpdateApplicationType updateApplicationType = new frmUpdateApplicationType((int)CellValue);
            updateApplicationType.ShowDialog();
            _ReloadGridViewData();
        }
    }
}
