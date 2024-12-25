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
    public partial class frmUpdateApplicationType : DevExpress.XtraEditors.XtraForm
    {
        int typeID;

        clsApplicatonTypes applicatonTypes;

        public frmUpdateApplicationType(int applicationTypeID)
        {
            InitializeComponent();
            typeID = applicationTypeID;
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            applicatonTypes = clsApplicatonTypes.FindApplicationType(typeID);

            if (applicatonTypes != null)
            {
                lblApplicationTypeID.Text = applicatonTypes.ApplicationTypeID.ToString();
                txtApplicationTypeTitle.Text = applicatonTypes.ApplicationTypeTitle.ToString();
                txtApplicationTypeFees.Text = applicatonTypes.ApplicationFees.ToString();
            }
            else
            {
                MessageBox.Show("Data error");
                this.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            applicatonTypes.ApplicationTypeTitle = txtApplicationTypeTitle.Text;
            applicatonTypes.ApplicationFees = decimal.Parse(txtApplicationTypeFees.Text);

            if(applicatonTypes.UpdateApplicationFees())
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error Occuer");
            }
            this.Close();
        }
    }
}
