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

        //
        // MARK: - Methods
        //

        private async void AddOrEditOfferForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;

            await loadOfferTypes();

            if (type == AddOrEditOfferFormType.Edit && selectedOffer != null)
            {
                PopulateFormFields(selectedOffer);
                LoadProfilePicture(selectedOffer);
            }

            this.Enabled = true;
        }

        private void PopulateFormFields(Offers selectedOffer)
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
        }
        private async void LoadProfilePicture(Offers selectedOffer)
        {
            var offer  = await _serviceOffers.GetById<Model.Offers>(selectedOffer.OfferId);
            if(offer != null)
            {
                selectedOffer.Picture = offer.Picture;
            }

            if (selectedOffer.Picture != null && selectedOffer.Picture.Length > 0)
            {
                offerPictureBox.Image = ImageConversionHelper.ByteArrayToImage(selectedOffer.Picture);
            }
        }


        private async Task loadOfferTypes()
        {
            var list = await _serviceOfferTypes.Get<List<Model.OfferTypes>>(null);
            offerMemberTypeComboBox.DataSource = list;
            offerMemberTypeComboBox.DisplayMember = "TypeName";
        }

        protected override bool ShouldResize() { return false; }

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

            if (offerPictureBox.ImageLocation != null)
            {

                byte[] pictureContent = File.ReadAllBytes(offerPictureBox.ImageLocation);

                // Resizing image to max 50 Kb
                // Answer: https://stackoverflow.com/questions/8790275/resize-image-which-is-placed-in-byte-array
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

        private void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
