using DVLD.Global_Classes;
using DVLD.Tests.Controls;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class frmTakeTest : DevExpress.XtraEditors.XtraForm
    {
        clsTest test;
        clsTestAppointment appointment;

        public frmTakeTest(int appointmentID)
        {
            InitializeComponent();
            ctrlScheduledTest1.LoadAppointmentData(appointmentID);
        }

        private void frmTakeTest_Load(object sender, System.EventArgs e)
        {
            appointment = ctrlScheduledTest1.SelectedAppointment;

            if (appointment.IsLocked == true)
            {
                btnSave.Enabled = false;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                txtNotes.Enabled = false;
            }

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            test = new clsTest();

            if (rbPass.Checked)
            {
                test.TestResult = true;
            }
            else
            {
                test.TestResult = false;
            }

            test.TestAppointmentID = ctrlScheduledTest1.AppointmentID;
            test.Notes = txtNotes.Text;
            test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            test.TestID = test.TakeTest();

            appointment.IsLocked = true;

            appointment.Save();
            this.Close();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
