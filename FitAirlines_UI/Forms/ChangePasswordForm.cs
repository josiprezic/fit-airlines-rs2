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
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        protected override bool ShouldResize()
        {
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var email = APIService.CurrentUser.Email;
            var oldPassword = oldPasswordTextBox.Text;
            var newPassword1 = newPasswordTextBox.Text;
            var newPassword2 = repeatNewPasswordTextBox.Text;

            // TODO: JR Check new password logic
            if (newPassword1 == newPassword2) // TODO: JR check password length
            {
                // Do something
            }
            else 
            {
                // Error
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
