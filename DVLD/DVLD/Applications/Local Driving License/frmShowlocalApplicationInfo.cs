using DVLD.Applications.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmShowlocalApplicationInfo : DevExpress.XtraEditors.XtraForm
    {
        int _LocalDrivingApplicationID;

        public frmShowlocalApplicationInfo(int ID)
        {
            InitializeComponent();
            _LocalDrivingApplicationID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowlocalApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlApplicatoinInfo1.LoadApplicationData(_LocalDrivingApplicationID);
        }
    }
}
