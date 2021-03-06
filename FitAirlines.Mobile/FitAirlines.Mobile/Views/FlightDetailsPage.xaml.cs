﻿using FitAirlines.Mobile.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitAirlines.Mobile.Views
{
    public partial class FlightDetailsPage : ContentPage
    {
        private readonly FlightDetailsViewModel _viewModel;

        public FlightDetailsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new FlightDetailsViewModel(Star1, Star2, Star3, Star4, Star5);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}