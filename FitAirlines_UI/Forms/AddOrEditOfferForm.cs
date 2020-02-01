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
    public enum AddOrEditOfferFormType 
    { 
        Add,
        Edit
    }

    public partial class AddOrEditOfferForm : BaseForm
    {
        //
        // MARK: - Variables
        //

        AddOrEditOfferFormType type;

        //
        // MARK: - Constructors
        //

        public AddOrEditOfferForm(AddOrEditOfferFormType type = AddOrEditOfferFormType.Add)
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
 
            Text = type == AddOrEditOfferFormType.Add ? Resources.AddOffer_FormName : Resources.EditOffer_FormName;

            personalInfoGroupBox.Text = Resources.AddOrEditOffer_PersonalInfo;
            imageGroupBox.Text = Resources.AddOrEditOffer_ImageOptions;

            offerNameLabel.Text = Resources.AddOrEditOffer_OfferName;
            requiredMemberLevelLabel.Text = Resources.AddOrEditOFfer_OfferMembershipLevel;
            offerDescriptionLabel.Text = Resources.AddOrEditOffer_OfferDescription;
            isActiveCheckBox.Text = Resources.AddOrEditOffer_IsActive;

            uploadofferPictureButton.Text = Resources.AddOrEditOffer_UploadImage;
            cancelButton.Text = Resources.Generic_Cancel;
            saveOfferButton.Text = Resources.Generic_Save;
        }

        //
        // MARK: - Actions
        //

        private void uploadofferPictureButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveOfferButton_Click(object sender, EventArgs e)
        {
            // TODO: JR
        }
    }
}
