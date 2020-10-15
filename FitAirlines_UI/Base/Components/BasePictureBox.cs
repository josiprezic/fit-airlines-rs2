using FitAirlines.UI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    class BasePictureBox : PictureBox
    {
        //
        // MARK: - Constructors
        //

        public BasePictureBox() { }

        //
        // MARK: - Public methods
        //

        public void UploadAndSetImage() 
        {
            ImageLocation = ImageUploadHelper.ShowDialogAndGetImageLocation();
        }

        //
        // MARK: - Protected methods
        //

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Configure();
        }

        protected virtual void SetupStyling()
        {
            BorderStyle = BorderStyle.FixedSingle;
            BackColor = Color.Gray;
            SizeMode = PictureBoxSizeMode.Zoom;
        }

        //
        // MARK: - Private methods
        //

        void Configure()
        {
            BaseSetup();
            SetupStyling();
        }

        void BaseSetup()
        {
            // TODO: JR
        }
    }
}
