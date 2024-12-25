using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }


        private int _PersonID = -1;

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {

            cbFilterSelection.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();

        }

        private void FindNow()
        {
            switch (cbFilterSelection.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));

                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrlPersonCard1.PersonID);
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterSelection.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void cbFilterSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void Person_DataBack(object sender, int PersonID)
        {
            cbFilterSelection.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();
            frmAddUpdatePerson.DataBack += Person_DataBack;
            frmAddUpdatePerson.ShowDialog();
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFindPerson.PerformClick();
            }

            if (cbFilterSelection.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }
    }
}
