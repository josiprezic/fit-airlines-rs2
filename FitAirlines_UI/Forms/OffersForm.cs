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
    public partial class OffersForm : BaseForm
    {
        //
        // MARK: - Constructors
        //

        public OffersForm()
        {
            InitializeComponent();
        }

        //
        // MARK: - Methods
        //

        protected override void SetupStrings()
        {
            base.SetupStrings();
            Text = Resources.Offers_FormName;
            offerNameLabel.Text = Resources.Offers_OfferName;
            dateTimePickerLabel.Text = Resources.Offers_OfferDate;
            isActiveCheckBox.Text = Resources.Offers_IsActiveOffer;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
            offerDateTimePicker.Clear();

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
            // TODO: JR perform search 
            offerDateTimePicker.Clear();
        }
    }
}