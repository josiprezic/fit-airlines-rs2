using FitAirlines.Model;
using FitAirlines.UI.Helpers;
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
        private readonly APIService _serviceUsers = new APIService("Users");
        private readonly APIService _serviceMembershipTypes = new APIService("MembershipTypes");


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
            var request = new Model.Requests.UsersInsertRequest
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                BirthDate = birthDateTimePicker.Value,
                Email = emailTextBox.Text,
                MembershipTypeId = (fitMembershipComboBox.SelectedItem as MembershipTypes).MembershipTypeId,
                Gender = genderComboBox.Text,
                IsActive = isActiveCheckBox.Checked,
                Credit = 0.0,
               
                ContactNumber = ContactNumberTextBox.Text,
                StartDate = DateTime.Now,
                Password = "InitialPassword", // TODO: JR
                PasswordConfirmation = "InitialPassword"
            };

            Model.Users user = null;
            if (type == AddOrEditUserFormType.Add)
            {
                user = await _serviceUsers.Insert<Model.Users>(request);
            }
            else 
            {
                
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

        private void AddOrEditUserForm_Load(object sender, EventArgs e)
        {
            loadMembershipTypes();
        }

        private async Task loadMembershipTypes()
        {
            var list = await _serviceMembershipTypes.Get<List<Model.MembershipTypes>>(null);
            fitMembershipComboBox.DataSource = list;
            fitMembershipComboBox.DisplayMember = "Title";
        }
    }
}
