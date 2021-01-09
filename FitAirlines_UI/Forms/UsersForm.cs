using FitAirlines.Model;
using FitAirlines.UI.Helpers;
using FitAirlines.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    public partial class UsersForm : BaseForm
    {

        private readonly APIService _serviceUsers = new APIService("Users");
        private readonly APIService _serviceMembershipTypes = new APIService("MembershipTypes");

        public UsersForm()
        {
            InitializeComponent();
            baseDataGridView1.AutoGenerateColumns = false;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //
        // MARK: - Styling
        //

        protected override void SetupStrings()
        {
            base.SetupStrings();

            Text = Resources.Users_FormName;
            nameSurnameLabel.Text = Resources.Users_NameSurname;
            genderLabel.Text = Resources.Users_Gender;
            memberLevelLabel.Text = Resources.Users_MemberLevel;
            isActiveCheckBox.Text = "Show only active users"; //Resources.Generic_IsActive;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();


            addImageButton.Image = Resources.Icon_Add;
            addImageButton.Text = Resources.Generic_Add;

            editImageButton.Image = Resources.Icon_Add;
            editImageButton.Text = Resources.Generic_Edit;

            genderComboBox.SelectedIndex = 0;
        }

        //
        // MARK: - Actions
        //

        private async void editImageButton_Click(object sender, EventArgs e)
        {
            var selectedRow = baseDataGridView1.SelectedRows[0];
            if(selectedRow == null)
            {
                MessageBox.Show("Please select a user for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(selectedRow.DataBoundItem is Model.Users selectedUser)
            {
                AddOrEditUserForm form = new AddOrEditUserForm(AddOrEditUserFormType.Edit, selectedUser);
                form.ShowDialog();
                await loadUsers();
            } 

        }

        private async void addImageButton_Click(object sender, EventArgs e)
        {
            AddOrEditUserForm form = new AddOrEditUserForm(AddOrEditUserFormType.Add);
            form.ShowDialog();
            await loadUsers();
        }

        //
        // MARK:- Data
        //

        private async void loadData()
        {
            await loadMembershipTypes();
            await loadUsers();
        }

        private async Task loadUsers()
        {
            this.Enabled = false;
            var request = new Model.Requests.UsersSearchRequest
            {
                Name = nameSurnameTextBox.Text,
                ShowOnlyActive = isActiveCheckBox.Checked
            };

            if (genderComboBox.SelectedIndex > 0)
            {
                request.Gender = genderComboBox.Text;
            }
            if (memberLevelComboBox.SelectedIndex > 0)
            {
                request.MembershipTypeId = (memberLevelComboBox.SelectedItem as MembershipTypes).MembershipTypeId;
            }

            var list = await _serviceUsers.Get<List<Model.Users>>(request);

            baseDataGridView1.DataSource = list;
            this.Enabled = true;
        }

        private async Task loadMembershipTypes()
        {
            var list = await _serviceMembershipTypes.Get<List<Model.MembershipTypes>>(null);
            list.Insert(0, new MembershipTypes() { MembershipTypeId = 0, Title = "All" });
            memberLevelComboBox.DataSource = list;
            memberLevelComboBox.DisplayMember = "Title";
        }


        private async void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await loadUsers();
        }

        private async void memberLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await loadUsers();

        }

        private async void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            await loadUsers();
        }

        private async void nameSurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            await loadUsers();
        }
    }
}
