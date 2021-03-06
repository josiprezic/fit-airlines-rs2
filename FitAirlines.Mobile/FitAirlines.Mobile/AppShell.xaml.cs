﻿using FitAirlines.Mobile.ViewModels;
using FitAirlines.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FitAirlines.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(OfferDetailsPage), typeof(OfferDetailsPage));
            Routing.RegisterRoute(nameof(FlightDetailsPage), typeof(FlightDetailsPage));
            Routing.RegisterRoute(nameof(FlightReservationPage), typeof(FlightReservationPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
