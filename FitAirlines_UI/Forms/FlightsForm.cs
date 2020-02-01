﻿using FitAirlines_UI.Properties;
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
    public partial class FlightsForm : BaseForm
    {
        //
        // MARK: - Constructors
        //

        public FlightsForm()
        {
            InitializeComponent();
        }

        //
        // MARK: - Protected methods
        //

        protected override void SetupStrings()
        {
            base.SetupStrings();
            Text = Resources.Flights_FormName;
            flightNameLabel.Text = Resources.Flights_FlightName;
            dateTimePickerLabel.Text = Resources.Flights_FlightDate;
            isActiveCheckBox.Text = Resources.Generic_IsActive;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
            flightDateTimePicker.Clear();

            searchImageButton.Image = Resources.Icon_Add;
            searchImageButton.Text = Resources.Generic_Search;

            addImageButton.Image = Resources.Icon_Add;
            addImageButton.Text = Resources.Generic_Add;

            editImageButton.Image = Resources.Icon_Add;
            editImageButton.Text = Resources.Generic_Edit;
        }

        //
        // MARK: - Private methods
        //

        private void ShowAddForm()
        {
            //AddOrEditOfferForm form = new AddOrEditOfferForm();
            //form.ShowDialog();
        }

        private void ShowEditForm()
        {
            //AddOrEditOfferForm form = new AddOrEditOfferForm(AddOrEditOfferFormType.Edit);
            //form.ShowDialog();
        }

        //
        // MARK: - Actions
        //

        private void searchImageButton_Click(object sender, EventArgs e)
        {

        }

        private void editImageButton_Click(object sender, EventArgs e)
        {

        }

        private void addImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
