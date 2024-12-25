using DVLD.Tests.Controls;
using System;

namespace DVLD.Tests
{
    public partial class frmScheduleTest : DevExpress.XtraEditors.XtraForm
    {
        public frmScheduleTest(int AppointmentID, int LocalDrivingAppID, int TestTypeID, int RetakeApplicationID = -1)
        {
            InitializeComponent();
            ctrlScheduleTest1.LoadAppointment(AppointmentID, LocalDrivingAppID, TestTypeID , RetakeApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
