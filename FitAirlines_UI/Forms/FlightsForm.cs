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
        //
        // MARK: - Constructors
        //

        public FlightsForm()
        {
            InitializeComponent();
        }

        //
        // MARK: - Protected methods
        //

        protected override void SetupStrings()
        {
            base.SetupStrings();
            Text = Resources.Flights_FormName;
            flightNameLabel.Text = Resources.Flights_FlightName;
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
            startDateTimePicker.Clear();

            searchImageButton.Image = Resources.Icon_Add;
            searchImageButton.Text = Resources.Generic_Search;

            addImageButton.Image = Resources.Icon_Add;
            addImageButton.Text = Resources.Generic_Add;

            editImageButton.Image = Resources.Icon_Add;
            editImageButton.Text = Resources.Generic_Edit;
        }

        //
        // MARK: - Actions
        //

        private void searchImageButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
        }

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
    }
}
