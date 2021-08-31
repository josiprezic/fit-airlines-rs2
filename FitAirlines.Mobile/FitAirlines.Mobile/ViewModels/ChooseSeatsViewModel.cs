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
    public class ChooseSeatsViewModel : BaseViewModel
    {
        private readonly APIService _serviceFlights = new APIService("Flights");
        private readonly APIService _serviceReservations = new APIService("Reservations");

        public Command LoadItemsCommand { get; }
        public Command BookNowCommand { get; }


        public ChooseSeatsViewModel()
        {
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            BookNowCommand = new Command(async () => await ExecuteBookNowCommand());
            Title = "Reserve Seats";
        }

        private async Task ExecuteLoadItemsCommand()
        {
            if (IsRequesting)
                return;

            //IsRequesting = true;
            //IsBusy = true;

            //try
            //{
            //    var item = await _serviceFlights.GetById<Flights>(_flightId);

            //    Flight = item;
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex);
            //}
            //finally
            //{
            //    IsBusy = false;
            //    IsRequesting = false;
            //}
        }

        private async Task ExecuteBookNowCommand()
        {
            
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
                    LoadItemsCommand.Execute(null);
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

        private string _chosenSeat = "N/A";

        public string ChosenSeat
        {
            get { return _chosenSeat; }
            set { SetProperty(ref _chosenSeat, value); }
        }



        #endregion

    }
}