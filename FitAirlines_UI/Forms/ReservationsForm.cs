﻿using FitAirlines.UI.Helpers;
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
    public partial class ReservationsForm : BaseForm
    {
        private readonly APIService _serviceFlights = new APIService("Flights");
        private readonly APIService _serviceReservations = new APIService("Reservations");
        private bool isFirstLoad = true;

        //
        // MARK: - Constructors
        //

        public ReservationsForm()
        {
            InitializeComponent();
            dgvReservations.AutoGenerateColumns = false;
            addImageButton.Visible = editImageButton.Visible = APIService.CurrentUser.UserRole.IsAbleToAddNewReservations;
        }

        //
        // MARK: - Methods
        //

        protected override void SetupStrings()
        {
            Text = Resources.Reservations_FormName;
            clientNameLabel.Text = Resources.Reservations_ClientName;
            flightLabel.Text = Resources.Reservations_Flight;
            reservationDateTimePickerLabel.Text = Resources.Reservations_ReservationDate;
            isActiveCheckBox.Text = Resources.Generic_IsActive;
        }

        protected override void SetupStyling()
        {
            base.SetupStyling();
            reservationDateTimePicker.Clear();

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

        private async void searchImageButton_Click(object sender, EventArgs e)
        {
            await LoadReservations();
        }

        private async void editImageButton_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows[0].DataBoundItem is Model.Reservations selectedReservation)
            {
                var form = new AddOrEditReservationForm(AddOrEditReservationForm.AddOrEditReservationFormType.Edit, selectedReservation);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await LoadReservations();
                }
            }

        }

        private async void addImageButton_Click(object sender, EventArgs e)
        {
            AddOrEditReservationForm form = new AddOrEditReservationForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                await LoadReservations();
            }
        }

        private async void ReservationsForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;

            await Task.WhenAll(
                loadFlights(),
                LoadReservations()
                );

            this.Enabled = true;
            isFirstLoad = false;
        }

        private async Task loadFlights()
        {
            var flList = await _serviceFlights.Get<List<Model.Flights>>(null);
            flList.Insert(0, new Model.Flights
            {
                FlightId = 0
            });
            flightComboBox.DataSource = flList;
        }

        private async Task LoadReservations()
        {
            var shouldEnableAtFinish = this.Enabled;
            this.Enabled = false;
            var request = new Model.Requests.ReservationsSearchRequest();

            if (isFirstLoad)
            {
                var Rlist = await _serviceReservations.Get<List<Model.Reservations>>(null);
                dgvReservations.DataSource = Rlist;

                this.Enabled = true;
                return;
            }


            if (isActiveCheckBox.Checked)
            {
                request.ShowOnlyActive = isActiveCheckBox.Checked;
            }

            if (reservationDateTimePicker.Checked)
            {
                request.ReservationDate = reservationDateTimePicker.Value;
            }

            if (flightComboBox.SelectedIndex > -1)
            {
                request.FlightId = (flightComboBox.SelectedItem as Model.Flights).FlightId;
            }

            if (!string.IsNullOrEmpty(clientNameTextBox.Text))
            {
                request.UserName = clientNameTextBox.Text;
            }

            var list = await _serviceReservations.Get<List<Model.Reservations>>(request);

            dgvReservations.DataSource = list;
            this.Enabled = shouldEnableAtFinish;
        }

        private async void reservationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await LoadReservations();
        }


        private async void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            await LoadReservations();
        }

        private async void flightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadReservations();
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                var reservation = dgvReservations.Rows[e.RowIndex].DataBoundItem as Model.Reservations;
                
                var form = new ReservationReportForm(reservation);
                form.ShowDialog();
            }
        }
    }
}
