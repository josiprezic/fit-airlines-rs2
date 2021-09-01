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
    public partial class LoginForm : Form
    {
        private readonly APIService _serviceUsers = new APIService("Users");
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            APIService.Email = emailTextbox.Text;
            APIService.Password = passwordTextBox.Text;

            try
            {
                APIService.CurrentUser = await _serviceUsers.Get<Model.Users>(null, "MyProfile");
                if(APIService.CurrentUser != null)
                {
                    if(APIService.CurrentUser.UserRole.Title == "FIT Member")
                    {
                        MessageBox.Show("You are not permitted to log in as FIT Member!", "Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
