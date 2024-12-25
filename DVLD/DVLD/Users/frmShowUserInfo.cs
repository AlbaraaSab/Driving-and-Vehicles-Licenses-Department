using System;

namespace DVLD.Users.Controls
{
    public partial class frmShowUserInfo : DevExpress.XtraEditors.XtraForm
    {
        public frmShowUserInfo(int Userid)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserInfo(Userid);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
