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
        private readonly APIService _serviceReservedSeats = new APIService("ReservedSeats");

        public ChooseSeatsViewModel()
        {
            Title = "Reserve Seats";
        }


        public async Task LoadFlight()
        {
            Flight = await _serviceFlights.GetById<Model.Flights>(_flightId);
        }

        public async Task<List<Model.ReservedSeats>> GetReservedSeats()
        {
            var request = new Model.Requests.ReservedSeatsSearchRequest
            {
                FlightId = int.Parse(_flightId)
            };

            return await _serviceReservedSeats.Get<List<Model.ReservedSeats>>(request);
        }


        #region Properties

        private Model.Flights _flight;

        public Model.Flights Flight
        {
            get { return _flight; }
            set { SetProperty(ref _flight, value); }
        }


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

       
        private string _chosenSeat = "N/A";

        public string ChosenSeat
        {
            get { return _chosenSeat; }
            set { SetProperty(ref _chosenSeat, value); }
        }



        #endregion

    }
}