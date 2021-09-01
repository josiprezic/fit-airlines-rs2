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
    public class FlightReservationViewModel : BaseViewModel
    {
        private readonly APIService _serviceFlights = new APIService("Flights");
        private readonly APIService _serviceReservations = new APIService("Reservations");

        public static int SeatDeparture = -1;
        public static int SeatArrival = -1;

        public FlightReservationViewModel()
        {
            SeatDeparture = -1;
            SeatArrival = -1;

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ChooseSeatsCommand = new Command(async () => await OnClickChooseSeats());
            ConfirmBookingCommand = new Command(async () => await OnClickConfirmBooking());
            Title = "Flight Reservation";
        }

        public void OnAppearing()
        {
            IsBusy = true;
            IsRequesting = false;
            LoadItemsCommand.Execute(null);
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

        private async Task OnClickChooseSeats()
        {
            await Shell.Current.GoToAsync($"{nameof(ChooseSeatsPage)}?{nameof(ChooseSeatsViewModel.FlightId)}={FlightId}");
        }

        private async Task OnClickConfirmBooking()
        {
            var request = new ReservationsInsertRequest
            {
                FlightId = int.Parse(FlightId),
                IsValid = true,
                UserId = APIService.CurrentUser.UserId,
                SeatIndexDeparture = SeatDeparture,
                SeatIndexReturn = SeatArrival
            };

            var entity = await _serviceReservations.Insert<Model.Reservations>(request);
            if(entity != null)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Your reservation was created successfully.", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
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

        #region Commands
        public Command LoadItemsCommand { get; }

        public Command ChooseSeatsCommand { get; }

        public Command ConfirmBookingCommand { get; }


        #endregion

    }
}