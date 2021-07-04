using FitAirlines.Mobile.Models;
using FitAirlines.Mobile.Services;
using FitAirlines.Mobile.Views;
using FitAirlines.Model;
using FitAirlines.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitAirlines.Mobile.ViewModels
{
    [QueryProperty(nameof(FlightId), nameof(FlightId))]
    public class FlightDetailsViewModel : BaseViewModel
    {
        private readonly APIService _serviceFlights = new APIService("Flights");

        public Command LoadItemsCommand { get; }
        public Command BookNowCommand { get; }

        private byte[] DefaultImage;

        public FlightDetailsViewModel(Image star1, Image star2, Image star3, Image star4, Image star5)
        {
            this.star1 = star1;
            this.star2 = star2;
            this.star3 = star3;
            this.star4 = star4;
            this.star5 = star5;

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            BookNowCommand = new Command(async () => await ExecuteBookNowCommand());
            DefaultImage = File.ReadAllBytes("default-destination.jpg");
            Title = "Details";
        }

        private async Task ExecuteLoadItemsCommand()
        {
            if (IsRequesting)
                return;

            IsRequesting = true;
            IsBusy = true;

            try
            {
                var item = await _serviceFlights.GetById<Flights>(_flightId);
                if (item.Picture.Length == 0)
                {
                    item.Picture = DefaultImage;
                }

                Flight = item;
                UpdateRatingStars();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
                IsRequesting = false;
            }
        }

        private void UpdateRatingStars()
        {
            var Star_empty = new FileImageSource { File = "star_empty.png" };
            var Star_filled = new FileImageSource { File = "star_filled.png" };
            var Star_half = new FileImageSource { File = "star_half.png" };

            star1.Source = Star_empty;
            star2.Source = Star_empty;
            star3.Source = Star_empty;
            star4.Source = Star_empty;
            star5.Source = Star_empty;

            double Rating = Flight.AverageRating;

            if (Rating >= 1)
                star1.Source = Star_filled;

            if (Rating >= 2)
                star2.Source = Star_filled;
            else if (Rating >= 1.5)
                star2.Source = Star_half;

            if (Rating >= 3)
                star3.Source = Star_filled;
            else if (Rating >= 2.5)
                star3.Source = Star_half;

            if (Rating >= 4)
                star4.Source = Star_filled;
            else if (Rating >= 3.5)
                star4.Source = Star_half;

            if (Rating == 5)
                star5.Source = Star_filled;
            else if (Rating >= 4.5)
                star5.Source = Star_half;
        }

        private async Task ExecuteBookNowCommand()
        {
            await Shell.Current.GoToAsync($"{nameof(FlightReservationPage)}?{nameof(FlightReservationViewModel.FlightId)}={FlightId}");
        }


        public void OnAppearing()
        {
            IsBusy = true;
            IsRequesting = false;
            LoadItemsCommand.Execute(null);
        }


        #region Properties

        private string _flightId;

        public string FlightId
        {
            get { return _flightId; }
            set
            {
                if (_flightId != value)
                {
                    SetProperty(ref _flightId, value);
                }
            }
        }

        private Flights _flight;
        private Image star1;
        private Image star2;
        private Image star3;
        private Image star4;
        private Image star5;

        public Flights Flight
        {
            get { return _flight; }
            set
            {
                if (_flight != value)
                {
                    SetProperty(ref _flight, value);
                }
            }
        }


        #endregion

    }
}