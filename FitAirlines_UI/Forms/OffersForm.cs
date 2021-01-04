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
    public partial class OffersForm : BaseForm
    {
        private readonly APIService _serviceOffers = new APIService("Offers");
        private readonly APIService _serviceOfferTypes = new APIService("OfferTypes");


        //
        // MARK: - Constructors
        //

        public OffersForm()
        {
            InitializeComponent();

            baseDataGridView1.AutoGenerateColumns = false;
        }

        //
        // MARK: - Protected methods
        //

        protected override void SetupStrings()
        {
            base.SetupStrings();
            Text = Resources.Offers_FormName;
            offerNameLabel.Text = Resources.Offers_OfferName;
            dateTimePickerLabel.Text = Resources.Offers_OfferDate;
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
        // MARK: - Private methods
        //

        private async void OffersForm_Load(object sender, EventArgs e)
        {
            await loadOffers();
        }


        private async Task loadOffers()
        {
            this.Enabled = false;
            var request = new Model.Requests.OffersSearchRequest
            {
                Name = offerNameTextBox.Text,
                ShowOnlyActive = isActiveCheckBox.Checked
            };
            if(offerDateTimePicker.Checked)
            {
                request.Date = offerDateTimePicker.Value.Date;
            }

            var list = await _serviceOffers.Get<List<Model.Offers>>(request);


            baseDataGridView1.DataSource = list;
            this.Enabled = true;
        }

      

        private async Task ShowAddForm()
        {
            AddOrEditOfferForm form = new AddOrEditOfferForm();
            form.ShowDialog();
            await loadOffers();
        }

        private async Task ShowEditForm()
        {
            var selectedRow = baseDataGridView1.SelectedRows[0];
            if (selectedRow == null)
            {
                MessageBox.Show("Please select an offer for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedRow.DataBoundItem is Model.Offers selectedOffer)
            {
                AddOrEditOfferForm form = new AddOrEditOfferForm(AddOrEditOfferFormType.Edit, selectedOffer);
                form.ShowDialog();
                await loadOffers();
            }

        }

        //
        // MARK: - Actions
        //

        private async void addImageButton_Click(object sender, EventArgs e)
        {
            await ShowAddForm();
        }

        private async void editImageButton_Click(object sender, EventArgs e)
        {
            await ShowEditForm();
        }

        private async void offerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            await loadOffers();
        }


        private async void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            await loadOffers();
        }

        private async void offerDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            await loadOffers();
        }
    }
}