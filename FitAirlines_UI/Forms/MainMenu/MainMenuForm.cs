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
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void SetupStrings()
        {
            Text = GetString("FormTitle");
            offersButton.Text = GetString("Offers");
            reservationsButton.Text = GetString("Reservations");
            usersButton.Text = GetString("Users");
            settingsButton.Text = GetString("Settings");
        }   
    }
}