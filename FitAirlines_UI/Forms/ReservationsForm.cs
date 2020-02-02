using FitAirlines_UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines_UI
{
    public partial class ReservationsForm : BaseForm
    {
        //
        // MARK: - Constructors
        //

        public ReservationsForm()
        {
            InitializeComponent();
        }

        //
        // MARK: - Methods
        //

        protected override void SetupStrings()
        {
            Text = Resources.Reservations_FormName;
            clientNameLabel.Text = Resources.Reservations_ClientName;
            flightLabel.Text = Resources.Reservations_Flight;
            reservationDateTimePickerLabel.Text = Resources.Reservations_ReservationDate;
            flightDateTimePickerLabel.Text = Resources.Reservations_FlightDate;
            isActiveCheckBox.Text = Resources.Generic_IsActive;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
            reservationDateTimePicker.Clear();
            flightDateTimePicker.Clear();

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

        }

        private void editImageButton_Click(object sender, EventArgs e)
        {

        }

        private void addImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
