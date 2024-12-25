using System;
using System.Data;
using DVLD_Business;
using DVLD.Properties;
using System.Windows.Forms;
using System.ComponentModel;
using DVLD.Global_Classes;
using System.IO;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : DevExpress.XtraEditors.XtraForm
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;


        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }


        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblAddUpdateFormTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblAddUpdateFormTitle.Text = "Update Person";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            //hide/show the remove linke incase there is no image for the person.
            btnRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.Properties.MaxValue = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.EditValue = dtpDateOfBirth.Properties.MaxValue;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.Properties.MinValue = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountries.SelectedIndex = cbCountries.FindString("Syria");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";


        }


        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.LoadAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _Person = clsPerson.FindPerson(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.EditValue = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountries.SelectedIndex = cbCountries.FindString(_Person.Country.CountryName);


            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            btnRemoveImage.Visible = (_Person.ImagePath != "");
        }


        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;

            int NationalityCountryID = clsCountry.FindCountry(cbCountries.Text).CountryID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = (DateTime)dtpDateOfBirth.EditValue;

            if (rbMale.Checked)
                _Person.Gender = (short)enGendor.Male;
            else
                _Person.Gender = (short)enGendor.Female;

            _Person.NationalityCountryID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblAddUpdateFormTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {

            SetImageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            SetImageDialog.FilterIndex = 1;
            SetImageDialog.RestoreDirectory = true;

            if (SetImageDialog.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = SetImageDialog.FileName;
                pbPersonImage.Load(selectedFilePath);
                btnRemoveImage.Visible = true;
                // ...
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            btnRemoveImage.Visible = false;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errProvider.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errProvider.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errProvider.SetError(txtEmail, null);
            };

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errProvider.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errProvider.SetError(txtNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errProvider.SetError(txtNationalNo, "National Number is used for another person!");

            }
            else
            {
                errProvider.SetError(txtNationalNo, null);
            }
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }
    }
}