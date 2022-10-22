using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitAirlines.Model;
using FitAirlines.UI.Reports;
using Microsoft.Reporting.WinForms;

namespace FitAirlines.UI
{
    public partial class ReservationReportForm : BaseForm
    {
        private readonly Reservations reservation;

        public ReservationReportForm(Model.Reservations reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
        }

        private void ReservationReportForm_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection
            {
                new ReportParameter("FullName", reservation.User.FirstName + " " + reservation.User.LastName),
                new ReportParameter("FlightCountry", reservation.Flight.CountryName),
                new ReportParameter("FlightCity", reservation.Flight.City.CityName),
                new ReportParameter("DepartureFlightDate", reservation.Flight.StartDate.ToShortDateString()),
                new ReportParameter("DepartureFlightTime", reservation.Flight.StartDate.ToShortTimeString()),
                new ReportParameter("DepartureSeat", reservation.SeatDeparture),
                new ReportParameter("MembershipType", reservation.User.MembershipType.Title),

                new ReportParameter("Price", reservation.Flight.Price.ToString()),

            new ReportParameter("ReservationDate", reservation.ReservationDate.ToShortDateString() + " " + reservation.ReservationDate.ToShortTimeString()),

                new ReportParameter("ReturnFlightDate", reservation.Flight.EndDate.ToShortDateString()),
                new ReportParameter("ReturnFlightTime", reservation.Flight.EndDate.ToShortTimeString()),
                new ReportParameter("ReturnSeat", reservation.SeatReturn),

                new ReportParameter("Notes", !string.IsNullOrEmpty(reservation.Notes) ? reservation.Notes : "None"),
            };

            if (reservation.Cashier == null)
            {
                rpc.Add(new ReportParameter("Cashier", "-"));
            }
            else
            {
                rpc.Add(new ReportParameter("Cashier", reservation.Cashier.FirstName + " " + reservation.Cashier.LastName));
            }

            reportViewer1.LocalReport.SetParameters(rpc);

            reportViewer1.RefreshReport();
        }
    }
}
