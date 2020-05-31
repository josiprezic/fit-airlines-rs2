using FitAirlines_UI.Properties;
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
using FitAirlines_API.Models;

namespace FitAirlines_UI
{
    public partial class UsersForm : BaseForm
    {
        public UsersForm()
        {
            InitializeComponent();
            loadData();
        }

        //
        // MARK: - Protected methods
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
            // TODO: JR
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

        private void loadData()
        {
            try
            {
                List<User> list = ApiHelper.GetData<User>(ApiHelper.Enpoints.GetUsers);
                baseDataGridView1.DataSource = list;
                setupDataGridView();
            }
            catch(ApiException ex)
            {
                MessageBox.Show(ex.message);
            }
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
