﻿using FitAirlines_UI.Properties;

namespace FitAirlines_UI
{
    public partial class MainMenuForm : BaseForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        protected override void SetupStrings()
        {
            Text = Resources.MainMenu_FormName;
            offersButton.Text = Resources.MainMenu_Offers;
            reservationsButton.Text = Resources.MainMenu_Reservations;
            usersButton.Text = Resources.MainMenu_Users;
            settingsButton.Text = Resources.MainMenu_Settings;
            flightsButton.Text = Resources.MainMenu_Flights;
        }

        private void offersButton_Click(object sender, System.EventArgs e)
        {
            ShowNewForm<OffersForm>();
        }

        private void flightsButton_Click(object sender, System.EventArgs e)
        {
            ShowNewForm<FlightsForm>();
        }
    }
}