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

        //
        // MARK: - Constructors
        //

        public AddOrEditFlightForm(AddOrEditFlightFormType type = AddOrEditFlightFormType.Add)
        {
            this.type = type;
            InitializeComponent();
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
            isActiveCheckBox.Checked = true;
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
    }
}
