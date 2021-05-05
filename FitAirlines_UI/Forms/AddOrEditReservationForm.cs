using FitAirlines.Model;
using FitAirlines.UI.Helpers;
using FitAirlines.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    public partial class AddOrEditReservationForm : BaseForm
    {

        private readonly APIService _serviceUsers = new APIService("Users");
        private readonly APIService _serviceOffers = new APIService("Offers");
        private readonly APIService _serviceFlights = new APIService("Flights");
        private readonly APIService _serviceReservations = new APIService("Reservations");

        private List<Users> allUsers = new List<Users>();
        private List<Offers> allOffers = new List<Offers>();
        private List<Flights> allFlights = new List<Flights>();

        private bool isFirstLoad = true;

        //
        // MARK: - Enums
        //

        public enum AddOrEditReservationFormType
        {
            Add,
            Edit
        }

        //
        // MARK: - Variables
        //

        AddOrEditReservationFormType type;
        private Model.Reservations selectedReservation;


        //
        // MARK: - Constructors
        //

        public AddOrEditReservationForm(AddOrEditReservationFormType type = AddOrEditReservationFormType.Add, Model.Reservations selectedReservation = null)
        {
            this.type = type;
            this.selectedReservation = selectedReservation;
            InitializeComponent();
        }

        //
        // MARK: - Methods
        //

        private async void AddOrEditReservationForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;

            await loadData();
            if (type == AddOrEditReservationFormType.Edit && selectedReservation != null)
            {
                this.selectedReservation = await _serviceReservations.GetById<Model.Reservations>(this.selectedReservation.ReservationId);
                await PopulateFormFields();
            }
            else if (type == AddOrEditReservationFormType.Add)
            {
                isActiveCheckBox.Checked = true;
            }

            this.Enabled = true;
        }

        private async Task PopulateFormFields()
        {
            isFirstLoad = true;

            clientComboBox.SetSelectedItem<Model.Users>(x => x.UserId == selectedReservation.UserId);

            offerComboBox.SetSelectedItem<Model.Offers>(x => x.OfferId == selectedReservation.Flight.OfferId);

            flightComboBox.SetSelectedItem<Model.Flights>(x => x.FlightId == selectedReservation.FlightId);

            isActiveCheckBox.Checked = selectedReservation.IsValid.Value;

            notesTextBox.Text = selectedReservation.Notes;

            isFirstLoad = false;

            await RefreshUI();

            departureSeatComboBox.SetSelectedItem<Model.ReservedSeats>(x => x.SeatName == selectedReservation.SeatDeparture);
            returnSeatComboBox.SetSelectedItem<Model.ReservedSeats>(x => x.SeatName == selectedReservation.SeatReturn);
        }

        private async Task loadData()
        {
            await Task.WhenAll(
                loadUsers(),
                loadOffers(),
                loadFlights()
                );

            isFirstLoad = false;
            await RefreshUI();
        }

        private async Task loadOffers()
        {
            var list = await _serviceOffers.Get<List<Model.Offers>>(null);
            allOffers = list;
            offerComboBox.DataSource = list;
            offerComboBox.DisplayMember = "OfferName";
        }

        private async Task loadUsers()
        {
            var list = await _serviceUsers.Get<List<Model.Users>>(null);
            list.Insert(0, new Users() { MembershipTypeId = 0, FirstName = "Select client", LastName = "" });
            allUsers = list;
            clientComboBox.DataSource = list;
        }

        private async Task loadFlights()
        {
            var list = await _serviceFlights.Get<List<Model.Flights>>(null);
            allFlights = list;
            flightComboBox.DataSource = list;
        }

        protected override bool ShouldResize() { return false; }

        protected override void SetupStrings()
        {
            Text = type == AddOrEditReservationFormType.Add ? Resources.AddReservation_FormName : Resources.EditReservation_FormName;

            clientLabel.Text = Resources.AddOrEditReservation_Client;
            offerLabel.Text = Resources.AddOrEditReservation_Offer;
            flightLabel.Text = Resources.AddOrEditReservation_Flight;

            seatStartLabel.Text = Resources.AddOrEditReservation_SeatStart;
            seatReturnLabel.Text = Resources.AddOrEditReservation_SeatReturn;

            priceTitleLabel.Text = Resources.AddOrEditReservation_PriceTitle;
            priceLabel.Text = Resources.AddOrEditReservation_Price;

            cancelButton.Text = Resources.Generic_Cancel;
            saveButton.Text = Resources.Generic_Save;
        }

        //
        // MARK: - Actions
        //

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Reservations reservation;

            if (type == AddOrEditReservationFormType.Edit)
            {
                // Update existing reservation
                var request = new Model.Requests.ReservationsUpdateRequest
                {
                    IsValid = isActiveCheckBox.Checked,
                    Notes = notesTextBox.Text,
                    SeatIndexDeparture = (departureSeatComboBox.SelectedItem as Model.ReservedSeats).SeatIndex,
                    SeatIndexReturn = (returnSeatComboBox.SelectedItem as Model.ReservedSeats).SeatIndex,
                };
                reservation = await _serviceReservations.Update<Model.Reservations>(selectedReservation.ReservationId, request);
            }
            else
            {

                // Add new reservation
                var request = new Model.Requests.ReservationsInsertRequest
                {
                    FlightId = (flightComboBox.SelectedItem as Model.Flights).FlightId,
                    Notes = notesTextBox.Text,
                    IsValid = isActiveCheckBox.Checked,
                    UserId = (clientComboBox.SelectedItem as Model.Users).UserId,
                    SeatIndexDeparture = (departureSeatComboBox.SelectedItem as Model.ReservedSeats).SeatIndex,
                    SeatIndexReturn = (returnSeatComboBox.SelectedItem as Model.ReservedSeats).SeatIndex,
                };
                reservation = await _serviceReservations.Insert<Model.Reservations>(request);
            }


            if (reservation != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
                this.Enabled = true;
        }

        private async void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await RefreshUI();
        }

        private async void offerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await RefreshUI();
        }

        private async void flightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await RefreshUI();
        }

        private bool isRefreshing = false;
        private async Task RefreshUI()
        {
            if (isRefreshing || isFirstLoad) { return; }
            isRefreshing = true;

            // Handle client not selected case 
            if (clientComboBox.SelectedIndex == 0)
            {
                offerComboBox.Enabled = false;
                flightComboBox.Enabled = false;
                departureSeatComboBox.Enabled = false;
                returnSeatComboBox.Enabled = false;

                isRefreshing = false;
                return;
            }

            // Client is selected, show appropriate offers/flights
            var selectedUser = (clientComboBox.SelectedItem as Users);

            // Show proper offers
            // All offers are shown to all users

            // Show proper flights
            var selectedOffer = (offerComboBox.SelectedItem as Offers);

            var selectedReservation = (flightComboBox.SelectedItem as Flights);

            var offerFlights = allFlights.Where(x => x.AvailableToMemberType.MembershipTypeId <= selectedUser.MembershipTypeId
                                                && x.OfferId == selectedOffer.OfferId).ToList();

            // Prevent reselection of default flight, keep and apply selection info if needed
            flightComboBox.DataSource = offerFlights;
            if (offerFlights.Contains(selectedReservation))
            {
                flightComboBox.SelectedItem = selectedReservation;
            }

            var newselectedReservation = (flightComboBox.SelectedItem as Flights);

            if(type == AddOrEditReservationFormType.Edit)
            {

                clientComboBox.Enabled =
                offerComboBox.Enabled = 
                flightComboBox.Enabled = false;
            }
            else
            {
                offerComboBox.Enabled =
                flightComboBox.Enabled = true;
            }

            if (newselectedReservation == null) { return; }


            var numberOfSeats = newselectedReservation.Plane.Capacity;
            var numberList = Enumerable.Range(0, numberOfSeats - 1).ToList();
            var reservations = await _serviceReservations.Get<List<Model.Reservations>>(new Model.Requests.ReservationsSearchRequest
            {
                ShowOnlyActive = true,
                FlightId = newselectedReservation.FlightId
            });

            var seatListDeparture = new List<ReservedSeats>();
            var seatListReturn = new List<ReservedSeats>();
            foreach (var seatIndex in numberList)
            {
                var seat = new ReservedSeats
                {
                    SeatIndex = seatIndex
                };

                if (type == AddOrEditReservationFormType.Edit || reservations.Any(x => x.SeatDeparture == seat.SeatName) == false)
                    seatListDeparture.Add(seat);

                if (type == AddOrEditReservationFormType.Edit || reservations.Any(x => x.SeatReturn == seat.SeatName) == false)
                    seatListReturn.Add(seat);
            }

            departureSeatComboBox.DataSource = seatListDeparture;
            departureSeatComboBox.DisplayMember = "SeatName";

            returnSeatComboBox.DataSource = seatListReturn;
            returnSeatComboBox.DisplayMember = "SeatName";

            departureSeatComboBox.Enabled = true;
            returnSeatComboBox.Enabled = true;

            // Update price info
            if (newselectedReservation != null)
            {
                var price = Math.Round(newselectedReservation.Price, 2);
                priceLabel.Text = price.ToString("0.00");
            }
            else
            {
                priceLabel.Text = "0.00";
            }

            isRefreshing = false;
        }

    }
}
