using FitAirlines.Model;
using FitAirlines.UI.Helpers;
using FitAirlines.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace FitAirlines.UI
{
    //
    // MARK: - Enums
    //

    public enum AddOrEditFlightFormType
    {
        Add,
        Edit
    }

    public partial class AddOrEditFlightForm : BaseForm
    {
        //
        // MARK: - Variables
        //

        AddOrEditFlightFormType type;
        private bool isFirstLoad = true;

        private List<Cities> allCities = new List<Cities>();
        private List<Airports> allAirports = new List<Airports>();
        private Model.Flights selectedFlight;

        private readonly APIService _serviceFlights = new APIService("Flights");
        private readonly APIService _serviceCountries = new APIService("Countries");
        private readonly APIService _serviceCities = new APIService("Cities");
        private readonly APIService _serviceAirports = new APIService("Airports");
        private readonly APIService _servicePlanes = new APIService("Planes");
        private readonly APIService _serviceOffers = new APIService("Offers");
        private readonly APIService _serviceMembershipTypes = new APIService("MembershipTypes");

        //
        // MARK: - Constructors
        //

        public AddOrEditFlightForm(AddOrEditFlightFormType type = AddOrEditFlightFormType.Add, Model.Flights selectedFlight = null)
        {
            this.type = type;
            this.selectedFlight = selectedFlight;
            InitializeComponent();
        }

        private async void AddOrEditFlightForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            SetupControls();
            await loadData();
            if (type == AddOrEditFlightFormType.Edit && selectedFlight != null)
            {
                PopulateFormFields();
                LoadPicture();
            }
            else if (type == AddOrEditFlightFormType.Add) 
            {
                isActiveCheckBox.Checked = true;
            }
            this.Enabled = true;
            isFirstLoad = false;
        }

        private void SetupControls() 
        {
            // Flight time setup
            // Should be between 10-10000
            FlightTimeNumericUpDown.Minimum = 10;
            FlightTimeNumericUpDown.Maximum = 10000;
            FlightTimeNumericUpDown.Value = 60;
            FlightTimeNumericUpDown.Increment = 10;
            FlightTimeNumericUpDown.ReadOnly = true;

            // Voucher discount
            // Should be between 0-100 [5]
            discPercentageUpDown.Minimum = 0;
            discPercentageUpDown.Maximum = 95;
            discPercentageUpDown.Value = 0;
            discPercentageUpDown.Increment = 5;
            discPercentageUpDown.ReadOnly = true;


            // Total price
            // Should be between 0-10 000
            // 
            priceNumericUpDown.Minimum = 10;
            priceNumericUpDown.Maximum = 100000;
            priceNumericUpDown.Value = 100;
            priceNumericUpDown.Increment = 10;
        }

        private void PopulateFormFields()
        {
            offerComboBox.SetSelectedItem<Model.Offers>(x => x.OfferId == selectedFlight.OfferId);
            countryComboBox.SetSelectedItem<Model.Countries>(x => x.CountryId == selectedFlight.City.Country.CountryId);

            resetCities();
            cityComboBox.SetSelectedItem<Model.Cities>(x => x.CityId == selectedFlight.CityId);
            resetAirports();
            destinationAirportComboBox.SetSelectedItem<Model.Airports>(x => x.AirportId == selectedFlight.DestinationAirportId);

            planeComboBox.SetSelectedItem<Model.Planes>(x => x.PlaneId == selectedFlight.Plane.PlaneId);

            pilotNameTextBox.Text = selectedFlight.PilotFullName;
            startDateTimePicker.Value = selectedFlight.StartDate;
            endDateTimePicker.Value = selectedFlight.EndDate;

            descriptionTextBox.Text = selectedFlight.ShortInfo;

            if (selectedFlight.VoucherDiscountPercentage.HasValue)
                discPercentageUpDown.Value = decimal.Parse(selectedFlight.VoucherDiscountPercentage.ToString());

            MinMembershipBaseComboBox.SetSelectedItem<Model.MembershipTypes>(x => x.MembershipTypeId == selectedFlight.AvailableToMemberTypeId);



            FlightTimeNumericUpDown.Value = (decimal) selectedFlight.FlightDuration.TotalMinutes;
            priceNumericUpDown.Value = decimal.Parse(selectedFlight.Price.ToString());

            isActiveCheckBox.Checked = selectedFlight.IsActive.Value;

            notesTextBox.Text = selectedFlight.Notes;
        }

        private async void LoadPicture()
        {
            var flight = await _serviceFlights.GetById<Model.Flights>(selectedFlight.FlightId);
            if (flight != null)
            {
                selectedFlight.Picture = flight.Picture;

                if (selectedFlight.Picture != null && selectedFlight.Picture.Length > 0)
                {
                    flightPictureBox.Image = ImageConversionHelper.ByteArrayToImage(selectedFlight.Picture);
                }
            }
        }

        private async Task loadData()
        {
            this.Enabled = false;

            await Task.WhenAll(
                loadCities(),
                loadCountries(),
                loadOffers(),
                loadMembersipTypes(),
                loadAirports(),
                loadPlanes()
                );

            resetCities();
            resetAirports();

            this.Enabled = true;
        }

        private async Task loadCountries()
        {
            var request = new Model.Requests.CountriesSearchRequest
            {
                HideCountriesWithNoCities = true
            };

            var list = await _serviceCountries.Get<List<Model.Countries>>(request);
            list = list.OrderBy(x => x.CountryName).ToList();
            list.Insert(0, new Model.Countries() { CountryId = 0, CountryName = "All" });

            countryComboBox.DataSource = list;
            countryComboBox.DisplayMember = "CountryName";
        }

        private async Task loadCities(bool shouldAddPleaseSelect = false)
        {
            var list = await _serviceCities.Get<List<Model.Cities>>(null);

            if (shouldAddPleaseSelect)
            {
                list.Insert(0, new Model.Cities() { CityId = 0, CityName = "Please select" });
            }

            this.allCities.AddRange(list);
            cityComboBox.DataSource = list;
            cityComboBox.DisplayMember = "CityName";
        }

        private async Task loadAirports(bool shouldAddPleaseSelect = false)
        {
            var list = await _serviceAirports.Get<List<Model.Airports>>(null);

            if (shouldAddPleaseSelect)
            {
                list.Insert(0, new Model.Airports() { AirportId = 0, AirportName = "Please select" });
            }

            this.allAirports.AddRange(list);
            destinationAirportComboBox.DataSource = list;
            destinationAirportComboBox.DisplayMember = "AirportName";
        }

        private async Task loadPlanes()
        {
            var list = await _servicePlanes.Get<List<Model.Planes>>(null);
            planeComboBox.DataSource = list;
            planeComboBox.DisplayMember = "PlaneName";
        }

        private async Task loadOffers()
        {
            var list = await _serviceOffers.Get<List<Model.Offers>>(null);
            offerComboBox.DataSource = list;
            offerComboBox.DisplayMember = "OfferName";
        }

        private async Task loadMembersipTypes()
        {
            var list = await _serviceMembershipTypes.Get<List<Model.MembershipTypes>>(null);
            MinMembershipBaseComboBox.DataSource = list;
            MinMembershipBaseComboBox.DisplayMember = "Title";
        }

        //
        // MARK: - Methods
        //

        protected override bool ShouldResize() { return false; }

        protected override void SetupStrings()
        {
            Text = type == AddOrEditFlightFormType.Add ? Resources.AddFlight_FormName : Resources.EditFlight_FormName;

            basicInfoGroupBox.Text = Resources.AddOrEditFlight_BasicInfo;
            imageGroupBox.Text = Resources.AddOrEditOffer_ImageOptions;

            cancelButton.Text = Resources.Generic_Cancel;
            saveButton.Text = Resources.Generic_Save;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
        }

        //
        // MARK: - Actions
        //

        private void uploadFlightPictureButton_Click(object sender, EventArgs e)
        {
            flightPictureBox.UploadAndSetImage();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            this.Enabled = false;

            var request = new Model.Requests.FlightsInsertRequest
            {
                AvailableToMemberTypeId = (MinMembershipBaseComboBox.SelectedItem as MembershipTypes).MembershipTypeId,
                CityId = (cityComboBox.SelectedItem as Cities).CityId,
                DestinationAirportId = (destinationAirportComboBox.SelectedItem as Airports).AirportId,
                FlightDuration = new TimeSpan(0, 0, decimal.ToInt32(FlightTimeNumericUpDown.Value), 0, 0),
                Notes = notesTextBox.Text,
                OfferId = (offerComboBox.SelectedItem as Offers).OfferId,
                PilotFullName = pilotNameTextBox.Text,
                PlaneId = (planeComboBox.SelectedItem as Planes).PlaneId,
                Price = decimal.ToDouble(priceNumericUpDown.Value),
                VoucherCode = PasswordHelper.CreatePassword(5),
                VoucherDiscountPercentage = decimal.ToDouble(discPercentageUpDown.Value),
                IsActive = isActiveCheckBox.Checked,
                ShortInfo = descriptionTextBox.Text,
                StartDate = startDateTimePicker.Value,
                EndDate = endDateTimePicker.Value
            };

            if (!string.IsNullOrEmpty(flightPictureBox.ImageLocation))
            {
                byte[] pictureContent = File.ReadAllBytes(flightPictureBox.ImageLocation);
                byte[] resizedPictureContent = ImageUploadHelper.Resize2Max50Kbytes(pictureContent);
                request.Picture = resizedPictureContent;
            }

            Model.Flights flight;
            if (type == AddOrEditFlightFormType.Add)
            {
                flight = await _serviceFlights.Insert<Model.Flights>(request);
            }
            else
            {
                flight = await _serviceFlights.Update<Model.Flights>(selectedFlight.FlightId, request);
            }

            if (flight != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
                this.Enabled = true;
        }


        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad && type == AddOrEditFlightFormType.Edit) { return; }
            resetCities();
            resetAirports();
        }


        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad && type == AddOrEditFlightFormType.Edit) { return; }
            resetAirports();
        }

        private void resetCities()
        {
            var selectedCountryId = (countryComboBox.SelectedItem as Countries).CountryId;

            // Check if country is selected
            if (selectedCountryId == 0)
            {
                // block this control if country is not selected
                var singleElementList = new List<Model.Cities>();
                singleElementList.Insert(0, new Model.Cities() { CityId = 0, CityName = "Select country" });
                cityComboBox.DataSource = singleElementList;
                cityComboBox.Enabled = false;
                return;
            }
            else
            {
                // Country is selected, display proper cities
                var countryCities = allCities.Where(x => x.CountryId == selectedCountryId).ToList<Cities>();
                var cbList = new List<Model.Cities>();
                cbList.InsertRange(0, countryCities);
                cbList = cbList.OrderBy(x => x.CityName).ToList();
                cityComboBox.DataSource = cbList;
                cityComboBox.Enabled = true;
            }
        }


        private void resetAirports()
        {
            var selectedCity = (cityComboBox.SelectedItem as Cities);
            var cityExists = selectedCity != null;
            var selectedCityId = cityExists ? selectedCity.CityId : 0;

            // Check if city is selected
            if (selectedCityId == 0)
            {
                // block this control if city is not selected
                var singleElementList = new List<Model.Airports>();
                singleElementList.Insert(0, new Model.Airports() { AirportId = 0, AirportName = "Select city" });
                destinationAirportComboBox.DataSource = singleElementList;
                destinationAirportComboBox.Enabled = false;
                return;
            }
            else
            {
                // city is selected, display proper airports
                var cityAirports = allAirports.Where(x => x.CityId == selectedCityId).ToList<Airports>();
                var cbList = new List<Model.Airports>();
                cbList.InsertRange(0, cityAirports);
                cbList = cbList.OrderBy(x => x.AirportName).ToList();
                destinationAirportComboBox.DataSource = cbList;
                destinationAirportComboBox.Enabled = true;
            }
        }

        //
        // MARK: - Valdation
        //

        // Country: 
        // Should not be "All"
        private void countryComboBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as BaseComboBox;
            var text = (field.SelectedItem as Countries).CountryName;

            if (text == "All")
            {
                errorProvider1.SetError(field, "Please select country value.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        // City: Should be selected
        private void cityComboBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as BaseComboBox;
            var selectedItem = field.SelectedItem as Cities;
            if (selectedItem == null)
            {
                errorProvider1.SetError(field, "Please select city value.");
                e.Cancel = true;
                return;
            }

            var text = selectedItem.CityName;
            if (text == null || text == "" || text == "Select country")
            {
                errorProvider1.SetError(field, "Please select city value.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        // Destination Airport: Should be selected
        private void destinationAirportComboBox_Validating(object sender, CancelEventArgs e)
        {

            var field = sender as BaseComboBox;
            var selectedItem = field.SelectedItem as Airports;
            if (selectedItem == null)
            {
                errorProvider1.SetError(field, "Please select destination airport.");
                e.Cancel = true;
                return;
            }

            var text = selectedItem.AirportName;

            if (text == null || text == "" || text == "Select city")
            {
                errorProvider1.SetError(field, "Please select destination airport.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        // Pilot name: At least two words with at least one letter
        // No numbers
        // Just "-" and " " allowed + letters
        private void pilotNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as TextBox;

            if (string.IsNullOrWhiteSpace(field.Text))
            {
                errorProvider1.SetError(field, Resources.Validation_FieldRequired);
                e.Cancel = true;
            }
            else if (field.Text.Length > 80)
            {
                errorProvider1.SetError(field, "Pilot name is too long.");
                e.Cancel = true;
            }
            else if (!field.Text.All((c => Char.IsLetter(c) || c == '-' || c == ' ')))
            {
                errorProvider1.SetError(field, "Please enter valid pilot name.");
                e.Cancel = true;
            } else if (!field.Text.Contains(" ")) 
            {
                errorProvider1.SetError(field, "Please enter full name.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        // Return date
        // Should have at least 5 hours difference
        // Should not be smalled than departure date
        private void endDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as DateTimePicker;
            var endDate = field.Value;
            var startDate = startDateTimePicker.Value;

            if(startDate > endDate)
            {
                errorProvider1.SetError(field, "Return date must be after departure date.");
                e.Cancel = true;
            } 
            else if((endDate - startDate).TotalHours < 5)
            {
                errorProvider1.SetError(field, "Time differnce between departure and return time shold be at least 5 hours.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        // Description
        // Should not be empty
        // Should have at least 10 letters
        // Should have max 400 letters
        private void descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as TextBox;

            if (string.IsNullOrWhiteSpace(field.Text))
            {
                errorProvider1.SetError(field, Resources.Validation_FieldRequired);
                e.Cancel = true;
            }
            else if (field.Text.Length > 400)
            {
                errorProvider1.SetError(field, "Description cannot be longer than 400 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        // Notes: Should not have more than 400 letters
        private void notesTextBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as TextBox;

            if (!string.IsNullOrWhiteSpace(field.Text) && field.Text.Length > 400)
            {
                errorProvider1.SetError(field, "Notes text cannot be longer than 400 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }
    }
}