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


        //
        // MARK: - Constructors
        //

        public AddOrEditReservationForm(AddOrEditReservationFormType type = AddOrEditReservationFormType.Add)
        {
            this.type = type;
            InitializeComponent();
        }

        //
        // MARK: - Methods
        //

        private async void AddOrEditReservationForm_Load(object sender, EventArgs e)
        {
            await loadData();
        }

        private async Task loadData()
        {
            this.Enabled = false;

            await Task.WhenAll(
                loadUsers(),
                loadOffers(),
                loadFlights()
                );

            isFirstLoad = false;
            RefreshUI();

            this.Enabled = true;
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

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void offerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void flightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void departureSeatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void returnSeatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private bool isRefreshing = false;
        private void RefreshUI()
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

            var selectedFlight = (flightComboBox.SelectedItem as Flights);

            var offerFlights = allFlights.Where(x => x.AvailableToMemberType.MembershipTypeId <= selectedUser.MembershipTypeId
                                                && x.OfferId == selectedOffer.OfferId).ToList();

            // Prevent reselection of default flight, keep and apply selection info if needed
            flightComboBox.DataSource = offerFlights;
            if (offerFlights.Contains(selectedFlight))
            {
                flightComboBox.SelectedItem = selectedFlight;
            }

            var newSelectedFlight = (flightComboBox.SelectedItem as Flights);

            offerComboBox.Enabled = true;
            flightComboBox.Enabled = true;

            if (newSelectedFlight == null) { return; }


            // TODO: Szef Configure plane seats combo boxes
            var numberOfSeats = newSelectedFlight.Plane.Capacity;
            var numberList = Enumerable.Range(1, numberOfSeats).ToList();

            //var seatList = new List<string>();
            //foreach (var seatIndex in numberList) {
            //    seatList.Append(SeatName(seatIndex));
            //}
            
            departureSeatComboBox.DataSource = numberList;
            returnSeatComboBox.DataSource = numberList;

            departureSeatComboBox.Enabled = true;
            returnSeatComboBox.Enabled = true;

            // Update price info
            if (newSelectedFlight != null)
            {
                var price = Math.Round(newSelectedFlight.Price, 2);
                priceLabel.Text = price.ToString("0.00");
            }
            else
            {
                priceLabel.Text = "0.00";
            }


            isRefreshing = false;
        }


        // TODO: Szef move to some helper class
        private string SeatName(int seatIndex) {
            var numberOfColumns = 6;
            var seatRow = (seatIndex / numberOfColumns) + 1;
            var seatColumn = (seatIndex % numberOfColumns) + 1;
            return seatRow.ToString();// + Convert.ToChar(64 + seatColumn);
        }

    }
}
