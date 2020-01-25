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
using System.Resources;
using System.Diagnostics;

namespace FitAirlines_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupStrings();

        }

        private void setupStrings()
        {
            Text = GetString("FormTitle");
            offersButton.Text = GetString("Offers");
            reservationsButton.Text = GetString("Reservations");
            usersButton.Text = GetString("Users");
            settingsButton.Text = GetString("Settings");
        }

        private String GetString(String key)
        {
            var resources = new ResourceManager(this.GetType());
            String result = resources.GetString(key);
            
            if (result == null)
            {
                Logger(this.GetType().Name + ": Error while getting string for key:" + key);
                return key;
            }
            return result;
        }

        private void Logger(String message) 
        {
            Debug.WriteLine(message);
        }
    }
}