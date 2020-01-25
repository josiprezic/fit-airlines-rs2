using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace FitAirlines_UI
{
    public class BaseForm: Form
    {


        protected BaseForm() { }

        override protected void OnLoad(EventArgs e) { Configure(); }

        protected virtual void SetupStrings() { }

        protected virtual void SetupStyling() { }

        protected void Logger(String message) { Debug.WriteLine(message); }

        protected void Configure()
        {
            SetupForm();
            SetupStrings();
            SetupStyling();
        }

        private void SetupForm()
        {
            // Disable resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            MaximizeBox = false;

            // Set form position to center
            CenterToParent();
        }
    }
}
