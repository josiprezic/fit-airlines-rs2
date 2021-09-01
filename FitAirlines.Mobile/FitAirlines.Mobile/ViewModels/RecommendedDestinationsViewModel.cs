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
    public class RecommendedDestinationsViewModel : BaseViewModel
    {
        private readonly APIService _serviceFlights = new APIService("Flights");

        public ObservableCollection<Flights> Items { get; } = new ObservableCollection<Flights>();
        public Command LoadItemsCommand { get; }
        public Command<Flights> ItemTapped { get; }
        public Command SearchCommand { get; }
        private byte[] DefaultImage;

        public RecommendedDestinationsViewModel()
        {
            Title = "Recommended Destinations";

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ItemTapped = new Command<Flights>(OnItemSelected);
            SearchCommand = new Command(OnSearch);
            ViewportWidth = (int)Math.Truncate(Application.Current.MainPage.Width);
            ViewportWidthLabel = (int)Math.Truncate(Application.Current.MainPage.Width);
            DefaultImage = File.ReadAllBytes("default-destination.jpg");
        }

        private async Task ExecuteLoadItemsCommand()
        {
            if (IsRequesting)
                return;

            IsRequesting = true;
            IsBusy = true;

            try
            {
                var items = await _serviceFlights.Get<List<Flights>>(null, "GetRecommendedFlights");
                Items.Clear();
                foreach (var item in items)
                {
                    if (item.Picture.Length == 0)
                        item.Picture = DefaultImage;
                    Items.Add(item);
                }
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

     
        public void OnAppearing()
        {
            IsBusy = true;
            IsRequesting = false;
            LoadItemsCommand.Execute(null);
        }


        async void OnItemSelected(Flights item)
        {
            if (item == null)
            {
                return;
            }

            // This will push the OfferDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(FlightDetailsPage)}?{nameof(FlightDetailsViewModel.FlightId)}={item.FlightId}");
        }

        private void OnSearch(object obj)
        {
            LoadItemsCommand.Execute(null);
        }

        #region Properties
        private string _searchTerm;

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                if (_searchTerm != value)
                {
                    SetProperty(ref _searchTerm, value);
                }
            }
        }
        

        private string _offerId;

        public string OfferId
        {
            get { return _offerId; }
            set
            {
                if (_offerId != value)
                {
                    SetProperty(ref _offerId, value);
                }
            }
        }


        private string _offerName;

        public string OfferName
        {
            get { return _offerName; }
            set
            {
                if (_offerName != value)
                {
                    SetProperty(ref _offerName, value);
                    Title = value;
                }
            }
        }

        private FontAttributes _topDestinationsIsActive;

        public FontAttributes TopDestinationsIsActive
        {
            get { return _topDestinationsIsActive; }
            set
            {
                if (_topDestinationsIsActive != value)
                {
                    SetProperty(ref _topDestinationsIsActive, value);
                    TopDestinationsIsActive = value;
                }
            }
        }

        private FontAttributes _nextFlightsIsActive;

        public FontAttributes NextFlightsIsActive
        {
            get { return _nextFlightsIsActive; }
            set
            {
                if (_nextFlightsIsActive != value)
                {
                    SetProperty(ref _nextFlightsIsActive, value);
                    NextFlightsIsActive = value;
                }
            }
        }


        #endregion
        public static double ViewportWidth { get; set; }
        public static double ViewportWidthLabel { get; set; }

    }
}