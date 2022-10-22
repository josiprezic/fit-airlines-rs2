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
    public partial class FlightsForm : BaseForm
    {
        private readonly APIService _serviceFlights = new APIService("Flights");
        private readonly APIService _serviceCountries = new APIService("Countries");
        private readonly APIService _serviceCities = new APIService("Cities");
        private readonly APIService _serviceOffers = new APIService("Offers");
        private readonly APIService _serviceMembershipTypes = new APIService("MembershipTypes");
        private readonly APIService _serviceReservations = new APIService("Reservations");

        private List<Cities> allCities = new List<Cities>();
        private bool isFirstLoad = true;

        //
        // MARK: - Constructors
        //

        public FlightsForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            addImageButton.Visible = editImageButton.Visible = APIService.CurrentUser.UserRole.IsAbleToAddNewFlights;
        }


        private async void FlightsForm_Load(object sender, EventArgs e)
        {
            await loadData();
            isFirstLoad = false;
        }

        //
        // MARK: - Protected methods
        //

        protected override void SetupStrings()
        {
            base.SetupStrings();
            Text = Resources.Flights_FormName;
            countryLabel.Text = Resources.AddOrEditFlight_Country;
            cityLabel.Text = Resources.AddOrEditFlight_City;
            startDateTimePickerLabel.Text = Resources.AddOrEditFlight_StartDate;
            endDateTimePickerLabel.Text = Resources.AddOrEditFlight_EndDate;
            offerLabel.Text = Resources.Flights_Offer;
            isActiveCheckBox.Text = Resources.Generic_IsActive;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
            
            addImageButton.Image = Resources.Icon_Add;
            addImageButton.Text = Resources.Generic_Add;

            editImageButton.Image = Resources.Icon_Add;
            editImageButton.Text = Resources.Generic_Edit;
        }

        //
        // MARK: - Actions
        //

       
        private async void editImageButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows[0].DataBoundItem is Model.Flights selectedFlight)
            {
                AddOrEditFlightForm form = new AddOrEditFlightForm(AddOrEditFlightFormType.Edit, selectedFlight);
                form.ShowDialog();
                await loadFlights();
            }
        }

        private async void addImageButton_Click(object sender, EventArgs e)
        {
            AddOrEditFlightForm form = new AddOrEditFlightForm(AddOrEditFlightFormType.Add);
            form.ShowDialog();
            await loadFlights();
        }

        private async Task loadData()
        {
            this.Enabled = false;
            
            await Task.WhenAll(
                loadCities(), 
                loadCountries(), 
                loadOffers(),
                loadMembersipTypes(),
                loadFlights()
                );

            this.Enabled = true;
        }


        private async Task loadCountries()
        {
            var list = await _serviceCountries.Get<List<Model.Countries>>(null);
            list.Sort();
            list.Insert(0, new Model.Countries() { CountryId = 0, CountryName = "All" });
            countryComboBox.DataSource = list;
            countryComboBox.DisplayMember = "CountryName";
        }

        private async Task loadCities()
        {
            var list = await _serviceCities.Get<List<Model.Cities>>(null);
            this.allCities.AddRange(list);
        }

        private async Task loadOffers()
        {
            var list = await _serviceOffers.Get<List<Model.Offers>>(null);
            list.Insert(0, new Model.Offers() { OfferId = 0, OfferName = "All" });
            offerComboBox.DataSource = list;
            offerComboBox.DisplayMember = "OfferName";
        }

        private async Task loadMembersipTypes()
        {
            var list = await _serviceMembershipTypes.Get<List<Model.MembershipTypes>>(null);
            minMembershipComboBox.DataSource = list;
            minMembershipComboBox.DisplayMember = "Title";
            minMembershipComboBox.SelectedItem = list.Last();
        }

        private async Task loadFlights()
        {
            var shouldEnableAtFinish = this.Enabled;
            this.Enabled = false;
            var request = new Model.Requests.FlightsSearchRequest();

            if (isFirstLoad) {
                var flList = await _serviceFlights.Get<List<Model.Flights>>(null);
                dataGridView.DataSource = flList;
                this.Enabled = true;
                return;
            }

            if (minMembershipComboBox.SelectedItem != null)
            {
                request.AvailableToMemberTypeId = (minMembershipComboBox.SelectedItem as MembershipTypes).MembershipTypeId;
            }

            if (countryComboBox.Text != "All")
            {
                request.CountryId = (countryComboBox.SelectedItem as Countries).CountryId;
            }

            if (cityComboBox.Text != "All")
            {
                request.CityId = (cityComboBox.SelectedItem as Cities).CityId;
            }

            if (offerComboBox.Text != "All")
            {
                request.OfferId = (offerComboBox.SelectedItem as Offers).OfferId;
            }

            if (isActiveCheckBox.Checked)
            {
                request.IsActive = isActiveCheckBox.Checked;
            }

            if (startDateTimePicker.Checked) 
            {
                request.StartDate = startDateTimePicker.Value;
            }

            if (endDateTimePicker.Checked)
            {
                request.EndDate = endDateTimePicker.Value;
            }
            
            var list = await _serviceFlights.Get<List<Model.Flights>>(request);

            dataGridView.DataSource = list;
            this.Enabled = shouldEnableAtFinish;
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshCitiesComboBoxItems();
        }

        private void refreshCitiesComboBoxItems() 
        {
            if (countryComboBox.SelectedItem == null) { return; }

            var countryId = (countryComboBox.SelectedItem as Countries).CountryId;
            
            if (countryId != 0)
            {
                // Country is selected ---> Show all cities from this particular country
                var countryCities = allCities.Where(x => x.CountryId == countryId).ToList<Cities>();

                var list = new List<Model.Cities>();
                list.InsertRange(0, countryCities);
                list.Sort();
                list.Insert(0, new Model.Cities() { CityId = 0, CityName = "All" });
                cityComboBox.DataSource = list;
                cityComboBox.DisplayMember = "CityName";
                cityComboBox.Enabled = true;
            }
            else 
            {
                // Country selection is "All Countries" ---> Show all cities and block control
                var list = new List<Model.Cities>();
                list.Insert(0, new Model.Cities() { CityId = 0, CityName = "All" });
                cityComboBox.DataSource = list;
                cityComboBox.DisplayMember = "CityName";
                cityComboBox.Enabled = false;
            }
            
        }//szef szef disocrd trolluje mnie :(1 sec ok

        private async void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            await loadFlights();
        }

        private async void offerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await loadFlights();
        }

        private async void minMembershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await loadFlights();
        }

        private async void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await loadFlights();
        }

        private async void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await loadFlights();
        }

        private async void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await loadFlights();
        }

        //
        // MARK: - Colors
        //

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Row in dataGridView.Rows)
            {
                if (Row.DataBoundItem is Model.Flights selectedFlight)
                {
                    if (selectedFlight.IsActive != true) 
                    {
                        Row.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else if (selectedFlight.EndDate.IsGreaterThan(DateTime.Now))
                    {
                        Row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        Row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private async void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                var flight = dataGridView.Rows[e.RowIndex].DataBoundItem as Model.Flights;

                var reservations = await _serviceReservations.Get<List<Model.Reservations>>(new Model.Requests.ReservationsSearchRequest
                {
                    FlightId = flight.FlightId
                });

                var form = new FlightReportForm(flight, reservations);
                form.ShowDialog();

            }
        }
    }
}
