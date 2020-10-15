using FitAirlines.Model;
using FitAirlines.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    //
    // MARK: - Enums
    //

    public enum AddOrEditUserFormType
    {
        Add,
        Edit
    }

    public partial class AddOrEditUserForm : BaseForm
    {

        //
        // MARK: - Variables
        //

        AddOrEditUserFormType type;

        //
        // MARK: - Constructors
        //

        public AddOrEditUserForm(AddOrEditUserFormType type = AddOrEditUserFormType.Add)
        {
            this.type = type;
            InitializeComponent();
        }

        //
        // MARK: - Methods
        //

        protected override bool ShouldResize() { return false; }

        protected override void SetupStrings()
        {
            Text = type == AddOrEditUserFormType.Add ? Resources.AddUser_FormName : Resources.EditUser_FormName;
            profilePictureGroupBox.Text = Resources.AddOrEditUser_ProfilePictureGroupBox;
            personalDataGroupBox.Text = Resources.AddOrEditOffer_PersonalInfo;
            actionsGroupBox.Text = Resources.AddOrEditUser_Actions;
            changeProfileImageButton.Text = Resources.AddOrEditUser_ChangeProfilePicture;
            changePasswordButton.Text = Resources.AddOrEditUser_ChangePassword;
            firstNameLabel.Text = Resources.AddOrEditUser_FirstName;
            lastNameLabel.Text = Resources.AddOrEditUser_LastName;
            birthDateLabel.Text = Resources.AddOrEditUser_BirthDate;
            genderLabel.Text = Resources.AddOrEditUser_Gender;
            isActiveCheckBox.Text = Resources.AddOrEditUser_IsActive;
            accountBalanceTextLabel.Text = Resources.AddOrEditUser_AccountBalance;
            addCreditButton.Text = Resources.AddOrEditUser_AddCredit;
            cancelButton.Text = Resources.AddOrEditUser_Cancel;
            saveButton.Text = Resources.AddOrEditUser_Save;

            // TODO: JR update
            accountBalanceValueLabel.Text = "0.00 $";
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
            if (type == AddOrEditUserFormType.Add) 
            {
                isActiveCheckBox.Checked = true;
                addCreditButton.Visible = false;
            }
        }

        private void addCreditButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            DateTime birthDate = birthDateTimePicker.Value;
            string email = "testtest@gmail.com"; // TODO: JR
            string mobileNumber = "2343242343";
            // picture // TODO: JR
            float credit = 0;
            DateTime startDate = DateTime.Now; // TODO: JR
            bool isActive = isActiveCheckBox.Checked;
            int userRoleId = 1;
            int membershipType = 1;

            Users user = new Users();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.BirthDate = birthDate;
            user.Email = email;
            user.ContactNumber = mobileNumber;
            user.Credit = credit;
            user.StartDate = startDate;
            user.IsActive = isActive;
            // user.UserRole = UserRole
            // user.MembershipType
            
        }

        private void changeProfileImageButton_Click(object sender, EventArgs e)
        {
            profilePictureBox.UploadAndSetImage();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
        }
    }
}
