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

        public UsersForm()
        {
            InitializeComponent();

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
        }

        //
        // MARK: - Actions
        //

        private void searchImageButton_Click(object sender, EventArgs e)
        {
            loadData();
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


            var request = new Model.Requests.UsersSearchRequest
            {
                Name = nameSurnameTextBox.Text,
                Gender = genderComboBox.Text,
                ShowOnlyActive = isActiveCheckBox.Checked
            };
            var list = await _serviceUsers.Get<List<Model.Users>>(request);

            baseDataGridView1.DataSource = list;
            setupDataGridView();
        }

        private void setupDataGridView()
        {
            List<string> visibleColumns = new List<string>();
            visibleColumns.Add("FirstName");
            visibleColumns.Add("LastName");
            visibleColumns.Add("Username");
            visibleColumns.Add("Email");
            visibleColumns.Add("ContactNumber");
            visibleColumns.Add("isActive");

            baseDataGridView1.showSelectedColumns(visibleColumns);
        }
    }
}
