using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace FitAirlines.UI
{
    public class BaseForm: Form
    {

        //
        // MARK: - Constants
        //

        static readonly int defaultFormHeight = 700;
        static readonly int defaultFormWidth = 1100;

        //
        // MARK: - Constructors
        //

        protected BaseForm() { }

        //
        // MARK: - Protected methods
        //

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Configure();
        }

        protected virtual bool ShouldResize() { return true; }

        protected virtual void SetupStrings() { }

        protected virtual void SetupStyling() { }

        protected void Logger(String message) { Debug.WriteLine(message); }
        
        protected void ShowNewForm<T>() where T : BaseForm, new()
        {
            T form = new T();
            form.ShowDialog();
        }

        //
        // MARK: - Private methods
        //

        void Configure()
        {
            SetupForm();
            SetupStrings();
            SetupStyling();
        }

        void SetupForm()
        {
            // Disable resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            MaximizeBox = false;

            if (ShouldResize())
            {
                // Set form size
                Size = new System.Drawing.Size(defaultFormWidth, defaultFormHeight);
                CenterToParent();
            }

            // Set form position to center
            CenterToParent();
        }
    }
}
