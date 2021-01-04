using FitAirlines.Model;
using FitAirlines.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI.Forms
{
    public partial class UserCreditForm : BaseForm
    {

        private readonly APIService _serviceUsers = new APIService("Users");


        private readonly Users selectedUser;

        public UserCreditForm(Users selectedUser)
        {
            InitializeComponent();
            this.selectedUser = selectedUser;
            PopulateFormFields(selectedUser);
        }

        private async void updateCreditLabel_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            var newCredit = decimal.ToDouble(creditValueNumericUpDown.Value);
            var totalCredit = selectedUser.Credit + newCredit;
            await saveUser(totalCredit);


            this.Close();
        }

        protected override bool ShouldResize() { return false; }

        private void PopulateFormFields(Users user) {
            creditValueLabel.Text = user.Credit.ToString();

        }


        private async Task saveUser(double newCredit) 
        {
            if (!ValidateChildren()) return;

            var request = new Model.Requests.UsersInsertRequest
            {
                FirstName = selectedUser.FirstName,
                LastName = selectedUser.LastName,
                BirthDate = selectedUser.BirthDate,
                Email = selectedUser.Email,
                MembershipTypeId = selectedUser.MembershipTypeId,
                UserRoleId = selectedUser.UserRoleId,
                Gender = selectedUser.Gender,
                IsActive = selectedUser.IsActive,
                Credit = newCredit,

                ContactNumber = selectedUser.ContactNumber,
                StartDate = selectedUser.StartDate
            };

            Model.Users user;
            user = await _serviceUsers.Update<Model.Users>(selectedUser.UserId, request);
            
            if (user != null)
            {
                DialogResult = DialogResult.OK;
               
            }
            else
            {
                this.Enabled = true;

            }

        }
    }
}
