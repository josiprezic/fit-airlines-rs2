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

namespace FitAirlines.UI
{
    public enum AddOrEditOfferFormType 
    { 
        Add,
        Edit
    }

    public partial class AddOrEditOfferForm : BaseForm
    {
        private readonly APIService _serviceOffers = new APIService("Offers");
        private readonly APIService _serviceOfferTypes = new APIService("OfferTypes");

        //
        // MARK: - Variables
        //

        private readonly AddOrEditOfferFormType type;
        private readonly Offers selectedOffer;

        //
        // MARK: - Constructors
        //

        public AddOrEditOfferForm(AddOrEditOfferFormType type = AddOrEditOfferFormType.Add, Model.Offers selectedOffer = null)
        {
            this.type = type;
            this.selectedOffer = selectedOffer;
            InitializeComponent();
        }

        override protected bool ShouldResize() { return false; }

        //
        // MARK: - Methods
        //

        private async void AddOrEditOfferForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;

            await loadOfferTypes();

            if (type == AddOrEditOfferFormType.Edit && selectedOffer != null)
            {
                PopulateFormFields();
                LoadProfilePicture();
            }

            this.offerMemberTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ActiveControl = offerNameTextBox;

            this.Enabled = true;
        }

        private void PopulateFormFields()
        {
            offerNameTextBox.Text = selectedOffer.OfferName;
            offerDescriptionTextBox.Text = selectedOffer.ShortInfo;
            isActiveCheckBox.Checked = selectedOffer.IsActive ?? false;

            foreach (OfferTypes item in offerMemberTypeComboBox.Items)
            {
                if (item.OfferTypeId == selectedOffer.OfferTypeId)
                {
                    offerMemberTypeComboBox.SelectedItem = item;
                    break;
                }
            }

            startDateTimePicker.Value = selectedOffer.StartDate;
            endDateTimePicker.Value = selectedOffer.EndDate;
        }

        private async void LoadProfilePicture()
        {
            var offer  = await _serviceOffers.GetById<Model.Offers>(selectedOffer.OfferId);
            if(offer != null)
            {
                selectedOffer.Picture = offer.Picture;

                if (selectedOffer.Picture != null && selectedOffer.Picture.Length > 0)
                {
                    offerPictureBox.Image = ImageConversionHelper.ByteArrayToImage(selectedOffer.Picture);
                }
            }
        }

        private async Task loadOfferTypes()
        {
            var list = await _serviceOfferTypes.Get<List<Model.OfferTypes>>(null);
            offerMemberTypeComboBox.DataSource = list;
            offerMemberTypeComboBox.DisplayMember = "TypeName";
        }

        protected override void SetupStrings()
        {
            Text = type == AddOrEditOfferFormType.Add ? Resources.AddOffer_FormName : Resources.EditOffer_FormName;

            personalInfoGroupBox.Text = Resources.AddOrEditOffer_PersonalInfo;
            imageGroupBox.Text = Resources.AddOrEditOffer_ImageOptions;

            offerNameLabel.Text = Resources.AddOrEditOffer_OfferName;
            requiredMemberLevelLabel.Text = Resources.AddOrEditOFfer_OfferMembershipLevel;
            offerDescriptionLabel.Text = Resources.AddOrEditOffer_OfferDescription;
            isActiveCheckBox.Text = "Active";

            uploadofferPictureButton.Text = Resources.Generic_UploadImage;
            cancelButton.Text = Resources.Generic_Cancel;
            saveOfferButton.Text = Resources.Generic_Save;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
            isActiveCheckBox.Checked = true;
        }

        //
        // MARK: - Actions
        //

        private void uploadofferPictureButton_Click(object sender, EventArgs e)
        {
            offerPictureBox.UploadAndSetImage();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveOfferButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            this.Enabled = false;

            var request = new Model.Requests.OffersInsertRequest
            {
                IsActive = isActiveCheckBox.Checked,
                OfferName = offerNameTextBox.Text,
                ShortInfo = offerDescriptionTextBox.Text,
                StartDate = startDateTimePicker.Value,
                EndDate = endDateTimePicker.Value,
                OfferTypeId = (offerMemberTypeComboBox.SelectedItem as OfferTypes).OfferTypeId
            };

            if (offerPictureBox.ImageLocation != null && offerPictureBox.ImageLocation.Length > 0)
            {
                byte[] pictureContent = File.ReadAllBytes(offerPictureBox.ImageLocation);
                byte[] resizedPictureContent = ImageUploadHelper.Resize2Max50Kbytes(pictureContent);
                request.Picture = resizedPictureContent;
            }

            Model.OfferTypes offer;
            if (type == AddOrEditOfferFormType.Add)
            {
                offer = await _serviceOffers.Insert<Model.OfferTypes>(request);
            }
            else
            {
                offer = await _serviceOffers.Update<Model.OfferTypes>(selectedOffer.OfferId, request);
            }

            if (offer != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
                this.Enabled = true;
        }

        //
        // MARK: - Validation
        //

        // Offer name
        // Should not be empty
        // Should have 2 - 20 characters
        private void offerNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as TextBox;

            if (string.IsNullOrWhiteSpace(field.Text))
            {
                errorProvider1.SetError(field, Resources.Validation_FieldRequired);
                e.Cancel = true;
            }
            else if (field.Text.Length > 30)
            {
                errorProvider1.SetError(field, "Offer name cannot be longer than 30 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        // Offer description
        private void offerDescriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as TextBox;

            if (string.IsNullOrWhiteSpace(field.Text))
            {
                errorProvider1.SetError(field, Resources.Validation_FieldRequired);
                e.Cancel = true;
            }
            else if (field.Text.Length > 400)
            {
                errorProvider1.SetError(field, "Offer description cannot be longer than 400 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }

        private void endDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            var field = sender as DateTimePicker;
            var endDate = field.Value;
            var startDate = startDateTimePicker.Value;

            if (endDate < startDate)
            {
                errorProvider1.SetError(field, "End date cannot be earlier than start date.");
                e.Cancel = true;
            }
            else if ((endDate - startDate).TotalDays < 5)
            {
                errorProvider1.SetError(field, "Difference between start and end date should be at least 5 days.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(field, null);
            }
        }
    }
}
