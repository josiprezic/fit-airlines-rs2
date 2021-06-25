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

        public ObservableCollection<Flights> Items { get; } = new ObservableCollection<Flights>();
        public Command LoadItemsCommand { get; }
        private byte[] DefaultImage;

        public FlightDetailsViewModel()
        {
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
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