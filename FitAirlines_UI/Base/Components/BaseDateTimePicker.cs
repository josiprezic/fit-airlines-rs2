using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    public partial class BaseDateTimePicker : DateTimePicker
    {
        //
        // MARK: - Constructors
        //

        public BaseDateTimePicker()
        {
            InitializeComponent();
            BaseSetup();
        }

        public BaseDateTimePicker(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            BaseSetup();
        }

        //
        // MARK: - Public methods
        //

        public void Clear() 
        {
            Value = DateTimePicker.MinimumDateTime;
        }

        public bool IsEmpty() 
        {
            return Value == DateTimePicker.MinimumDateTime;
        }

        //
        // MARK: - Private methods
        //

        void CheckForClearValue() 
        {
            if (Value == DateTimePicker.MinimumDateTime)
            {
                Value = DateTime.Now; // This is required in order to show current month/year when user reopens the date popup.
                Format = DateTimePickerFormat.Custom;
                CustomFormat = " ";
            }
            else
            {
                Format = DateTimePickerFormat.Long;
            }

        }

        private void BaseSetup() 
        {
            Format = DateTimePickerFormat.Long;
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            CheckForClearValue();
        }
    }
}
