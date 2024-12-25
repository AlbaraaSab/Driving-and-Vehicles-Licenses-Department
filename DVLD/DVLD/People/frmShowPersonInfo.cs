using DVLD_Business;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : DevExpress.XtraEditors.XtraForm
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
           ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(NationalNo);
        }
    }
}