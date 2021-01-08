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

        private readonly APIService _serviceCountries = new APIService("Countries");
        private readonly APIService _serviceCities = new APIService("Cities");
        private readonly APIService _serviceAirports = new APIService("Airports");
        private readonly APIService _servicePlanes = new APIService("Planes");
        private readonly APIService _serviceOffers = new APIService("Offers");
        private readonly APIService _serviceMembershipTypes = new APIService("MembershipTypes");

        //
        // MARK: - Constructors
        //

        public AddOrEditFlightForm(AddOrEditFlightFormType type = AddOrEditFlightFormType.Add)
        {
            this.type = type;
            InitializeComponent();
        }


        private async void AddOrEditFlightForm_Load(object sender, EventArgs e)
        {
            await loadData();
            isFirstLoad = false;

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

            // TODO: JR load flight if needed.
           
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

        private async Task loadCities(bool shouldAddPleaseSelect = false)
        {
            var list = await _serviceCities.Get<List<Model.Cities>>(null);
            
            if (shouldAddPleaseSelect)
            {
                list.Insert(0, new Model.Cities() { CityId = 0, CityName= "Please select" });
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

            offerLabel.Text = Resources.AddOrEditFlight_FlightOffer;
            countryLabel.Text = Resources.AddOrEditFlight_Country;
            cityLabel.Text = Resources.AddOrEditFlight_City;
            startDateLabel.Text = Resources.AddOrEditFlight_StartDate;
            endDateLabel.Text = Resources.AddOrEditFlight_EndDate;
            descriptionLabel.Text = Resources.AddOrEditFlight_FlightDescription;
            isActiveCheckBox.Text = Resources.Generic_IsActive;
            
            uploadFlightPictureButton.Text = Resources.Generic_UploadImage;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
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
                cbList.Sort();
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
                cbList.Sort();
                destinationAirportComboBox.DataSource = cbList;
                destinationAirportComboBox.Enabled = true;
            }
        }
    }
}
