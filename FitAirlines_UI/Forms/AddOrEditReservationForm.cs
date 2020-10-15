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

        protected override bool ShouldResize() { return false; }

        protected override void SetupStrings()
        {
            Text = type == AddOrEditReservationFormType.Add ? Resources.AddReservation_FormName : Resources.EditReservation_FormName;

            clientLabel.Text = Resources.AddOrEditReservation_Client;
            offerLabel.Text = Resources.AddOrEditReservation_Offer;
            flightLabel.Text = Resources.AddOrEditReservation_Flight;

            seatStartLabel.Text = Resources.AddOrEditReservation_SeatStart;
            seatReturnLabel.Text = Resources.AddOrEditReservation_SeatReturn;
            priceDiscountLabel.Text = Resources.AddOrEditReservation_Discount;

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
    }
}
