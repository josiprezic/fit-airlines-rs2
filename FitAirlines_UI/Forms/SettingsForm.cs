using FitAirlines.Model;
using FitAirlines.UI.Forms;
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
    public partial class SettingsForm : BaseForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        protected override bool ShouldResize()
        {
            return false;
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            ShowNewForm<ChangePasswordForm>();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

                var loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}
