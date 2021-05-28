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
    public partial class ChangePasswordForm : BaseForm
    {
        private readonly APIService _serviceUsers = new APIService("Users");
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        protected override bool ShouldResize()
        {
            return false;
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            var email = APIService.CurrentUser.Email;
            var oldPassword = oldPasswordTextBox.Text;
            var newPassword1 = newPasswordTextBox.Text;
            var newPassword2 = repeatNewPasswordTextBox.Text;

            if (ValidateForm())
            {
                var request = new Model.Requests.UsersUpdatePasswordRequest
                {
                    NewPassword = newPassword1,
                    OldPassword = oldPassword
                };
                var result = await _serviceUsers.Update<bool>(APIService.CurrentUser.UserId, request, "UpdatePassword");
                if (result)
                {
                    APIService.Password = newPassword1;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            var oldPassword = oldPasswordTextBox.Text;
            var newPassword1 = newPasswordTextBox.Text;
            var newPassword2 = repeatNewPasswordTextBox.Text;

            if(oldPassword.IsNullOrEmpty())
            {
                errorProvider1.SetError(oldPasswordTextBox, "Old password is required");
                return false;
            }
            errorProvider1.SetError(oldPasswordTextBox, null);

            if (!newPassword1.IsBetweenLength(8, 50))
            {
                errorProvider1.SetError(newPasswordTextBox, "New password must contain 8 to 50 characters.");
                return false;
            }
            if (newPassword1 != newPassword2)
            {
                errorProvider1.SetError(newPasswordTextBox, "New password does not match confirmation.");
                return false;
            }

            errorProvider1.SetError(newPasswordTextBox, null);

            return true;
        }
    }
}
