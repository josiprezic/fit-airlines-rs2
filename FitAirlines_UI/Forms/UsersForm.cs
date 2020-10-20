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
            isActiveCheckBox.Text = Resources.Generic_IsActive;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();

            searchImageButton.Image = Resources.Icon_Add;
            searchImageButton.Text = Resources.Generic_Search;

            addImageButton.Image = Resources.Icon_Add;
            addImageButton.Text = Resources.Generic_Add;

            editImageButton.Image = Resources.Icon_Add;
            editImageButton.Text = Resources.Generic_Edit;

            genderComboBox.SelectedIndex = 0;
        }

        //
        // MARK: - Actions
        //

        private void searchImageButton_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
            AddOrEditUserForm form = new AddOrEditUserForm(AddOrEditUserFormType.Edit);
            form.ShowDialog();
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            AddOrEditUserForm form = new AddOrEditUserForm(AddOrEditUserFormType.Add);
            form.ShowDialog();
        }

        //
        // MARK:- Data
        //

        private async void loadData()
        {
            searchImageButton.Enabled = false;
            await loadMembershipTypes();
            await loadUsers();
            searchImageButton.Enabled = true;
        }

        private async Task loadUsers()
        {
            var request = new Model.Requests.UsersSearchRequest
            {
                Name = nameSurnameTextBox.Text,
                ShowOnlyActive = isActiveCheckBox.Checked,
                MembershipTypeId = (memberLevelComboBox.SelectedItem as MembershipTypes).MembershipTypeId
            };

            if(genderComboBox.Text != "All")
            {
                request.Gender = genderComboBox.Text;
            }

            var list = await _serviceUsers.Get<List<Model.Users>>(request);

            baseDataGridView1.DataSource = list;
        }

        private async Task loadMembershipTypes()
        {
            var list = await _serviceMembershipTypes.Get<List<Model.MembershipTypes>>(null);
            list.Insert(0, new MembershipTypes() { MembershipTypeId = 0, Title = "All" }) ;
            memberLevelComboBox.DataSource = list;
            memberLevelComboBox.DisplayMember = "Title";
        }

        private void nameSurnameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                loadUsers();
            }
        }
    }
}
