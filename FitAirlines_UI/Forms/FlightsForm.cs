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

        //
        // MARK: - Constructors
        //

        public FlightsForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;

        }


        private async void FlightsForm_Load(object sender, EventArgs e)
        {
            await loadData();
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
            minMembershipTypeLabel.Text = Resources.AddOrEditOFfer_OfferMembershipLevel;
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

       
        private void editImageButton_Click(object sender, EventArgs e)
        {
            AddOrEditFlightForm form = new AddOrEditFlightForm(AddOrEditFlightFormType.Edit);
            form.ShowDialog();
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            AddOrEditFlightForm form = new AddOrEditFlightForm(AddOrEditFlightFormType.Add);
            form.ShowDialog();
        }

        private async Task loadData()
        {
            this.Enabled = false;
            await loadCountries();
            await loadFlights();
            this.Enabled = true;
        }


        private async Task loadCountries() 
        {
            var list = await _serviceCountries.Get<List<Model.Countries>>(null);
            list.Insert(0, new Model.Countries() { CountryId = 0, CountryName = "All" });
            countryComboBox.DataSource = list;
            countryComboBox.DisplayMember = "CountryName";
        }

        private async Task loadFlights()
        {
            var shouldEnableAtFinish = this.Enabled;
            this.Enabled = false;
            var request = new Model.Requests.FlightsSearchRequest

            {
                AvailableToMemberTypeId = 1  
                //Name = nameSurnametextbox.text,
                //showonlyactive = isactivecheckbox.checked,
                //membershiptypeid = (memberLevelComboBox.SelectedItem as MembershipTypes).MembershipTypeId
            };

            //if (genderComboBox.Text != "All")
            //{
            //    request.Gender = genderComboBox.Text;
            //}

            var list = await _serviceFlights.Get<List<Model.Flights>>(request);

            dataGridView.DataSource = list;
            this.Enabled = shouldEnableAtFinish;
        }

    }
}
