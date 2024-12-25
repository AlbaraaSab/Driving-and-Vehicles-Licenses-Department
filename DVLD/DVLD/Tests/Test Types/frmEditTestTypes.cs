using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Tests.Test_Types
{
    public partial class frmEditTestTypes : DevExpress.XtraEditors.XtraForm
    {

        int Id;
        clsTestTypes testTypes;

        public frmEditTestTypes(int TestTypeId)
        {
            InitializeComponent();

            Id = TestTypeId;
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            testTypes = clsTestTypes.FindTestType(Id);

            lblTestTypeID.Text = testTypes.TestTypeID.ToString();
            txtTestTypeTitle.Text = testTypes.TestTypeTitle.ToString();
            txtTestTypeDesciption.Text = testTypes.TestTypeDescription.ToString();
            txtTestTypeFees.Text = testTypes.TestTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            testTypes.TestTypeTitle = txtTestTypeTitle.Text;
            testTypes.TestTypeDescription = txtTestTypeDesciption.Text;
            testTypes.TestTypeFees = decimal.Parse(txtTestTypeFees.Text);

            if (testTypes.UpdateTestType())
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error Occuer");
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
