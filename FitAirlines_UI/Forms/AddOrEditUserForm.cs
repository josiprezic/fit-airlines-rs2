using FitAirlines.Model;
using FitAirlines.UI.Helpers;
using FitAirlines.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private readonly APIService _serviceUsers = new APIService("Users");
        private readonly APIService _serviceMembershipTypes = new APIService("MembershipTypes");
        private readonly APIService _serviceUserRoles = new APIService("UserRoles");



        //
        // MARK: - Variables
        //

        private readonly AddOrEditUserFormType type;
        private readonly Users selectedUser;

        //
        // MARK: - Constructors
        //

        public AddOrEditUserForm(AddOrEditUserFormType type = AddOrEditUserFormType.Add, Users selectedUser = null)
        {
            this.type = type;
            this.selectedUser = selectedUser;

            InitializeComponent();

        }

        //
        // MARK: - Methods
        //

        private async void AddOrEditUserForm_Load(object sender, EventArgs e)
        {
            await loadMembershipTypes();
            await loadUserRoles();

            if (type == AddOrEditUserFormType.Edit && selectedUser != null)
            {
                PopulateFormFields(selectedUser);
            }

        }

        private async Task loadMembershipTypes()
        {
            var list = await _serviceMembershipTypes.Get<List<Model.MembershipTypes>>(null);
            fitMembershipComboBox.DataSource = list;
            fitMembershipComboBox.DisplayMember = "Title";
        }

        private async Task loadUserRoles()
        {
            var list = await _serviceUserRoles.Get<List<Model.UserRoles>>(null);
            userRoleComboBox.DataSource = list;
            userRoleComboBox.DisplayMember = "Title";
        }

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
            emailLabel.Text = "Email"; // TODO: JR add resource
            birthDateLabel.Text = Resources.AddOrEditUser_BirthDate;
            genderLabel.Text = Resources.AddOrEditUser_Gender;
            isActiveCheckBox.Text = Resources.AddOrEditUser_IsActive;
            accountBalanceTextLabel.Text = Resources.AddOrEditUser_AccountBalance;
            addCreditButton.Text = Resources.AddOrEditUser_AddCredit;
            cancelButton.Text = Resources.AddOrEditUser_Cancel;
            saveButton.Text = Resources.AddOrEditUser_Save;
            fitMembershipLabel.Text = "Membership type"; // TODO: JR
            contactNumberLabel.Text = "Tel number";

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

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            var request = new Model.Requests.UsersInsertRequest
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                BirthDate = birthDateTimePicker.Value,
                Email = emailTextBox.Text,
                MembershipTypeId = (fitMembershipComboBox.SelectedItem as MembershipTypes).MembershipTypeId,
                UserRoleId = (userRoleComboBox.SelectedItem as UserRoles).UserRoleId,
                Gender = genderComboBox.Text,
                IsActive = isActiveCheckBox.Checked,
                Credit = 0.0,

                ContactNumber = ContactNumberTextBox.Text,
                StartDate = DateTime.Now,
                Password = "InitialPassword", // TODO: JR
                PasswordConfirmation = "InitialPassword",
            };

            if(profilePictureBox.ImageLocation != null)
            {
                byte[] pictureContent = File.ReadAllBytes(profilePictureBox.ImageLocation);
                request.Picture = pictureContent;
            }

            Model.Users user;
            if (type == AddOrEditUserFormType.Add)
            {
                user = await _serviceUsers.Insert<Model.Users>(request);
            }
            else
            {
                user = await _serviceUsers.Update<Model.Users>(selectedUser.UserId, request);
            }

            if (user != null)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void changeProfileImageButton_Click(object sender, EventArgs e)
        {
            profilePictureBox.UploadAndSetImage();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
        }


        private void PopulateFormFields(Users selectedUser)
        {
            firstNameTextBox.Text = selectedUser.FirstName;
            lastNameTextBox.Text = selectedUser.LastName;
            birthDateTimePicker.Value = selectedUser.BirthDate;
            emailTextBox.Text = selectedUser.Email;
            foreach (MembershipTypes item in fitMembershipComboBox.Items)
            {
                if(item.MembershipTypeId == selectedUser.MembershipTypeId)
                {
                    fitMembershipComboBox.SelectedItem = item;
                    break;
                }
            }

            foreach (UserRoles item in userRoleComboBox.Items)
            {
                if (item.UserRoleId == selectedUser.UserRoleId)
                {
                    userRoleComboBox.SelectedItem = item;
                    break;
                }
            }



            genderComboBox.Text = selectedUser.Gender;
            isActiveCheckBox.Checked = selectedUser.IsActive ?? false;
            ContactNumberTextBox.Text = selectedUser.ContactNumber;

            if(selectedUser.Picture != null && selectedUser.Picture.Length > 0)
            {
                profilePictureBox.Image = ImageConversionHelper.ByteArrayToImage(selectedUser.Picture);
            }
        }

        private void basicTextBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as TextBox;

            if(string.IsNullOrWhiteSpace(field.Text))
            {
                errorProvider1.SetError(field, Resources.Validation_FieldRequired);
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {

            var field = sender as TextBox;

            if (string.IsNullOrWhiteSpace(field.Text))
            {
                errorProvider1.SetError(field, Resources.Validation_FieldRequired);
            }
            else if(!ValidateEmail(field.Text))
            {
                errorProvider1.SetError(field, Resources.Validation_EmailInvalid);
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        bool ValidateEmail( string emailAddress)
        {
            return true;
        }
    }
}
