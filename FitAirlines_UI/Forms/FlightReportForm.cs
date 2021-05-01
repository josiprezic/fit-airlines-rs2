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
    public partial class FlightReportForm : BaseForm
    {
        private readonly Flights flight;
        private readonly List<Reservations> reservations;

        public FlightReportForm(Model.Flights flight, List<Model.Reservations> reservations)
        {
            InitializeComponent();
            this.flight = flight;
            this.reservations = reservations;
        }

        private void FlightReportForm_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection
            {
                new ReportParameter("Country", flight.CountryName),
                new ReportParameter("CityName", flight.City.CityName),
                new ReportParameter("DepartureDate", flight.StartDate.ToShortDateString() + " " + flight.StartDate.ToShortTimeString()),
                new ReportParameter("ReturnDate", flight.EndDate.ToShortDateString() + " " + flight.EndDate.ToShortTimeString()),
                new ReportParameter("Offer", flight.Offer.OfferName),
                new ReportParameter("Availability", flight.AvailableToMemberType.Title),
                new ReportParameter("Capacity", flight.Capacity.ToString()),
                new ReportParameter("Active", flight.IsActive.HasValue ? (flight.IsActive.Value ? "Yes" : "No") : "No"),
                new ReportParameter("Plane", flight.Plane.PlaneName),
                new ReportParameter("PilotFullName", flight.PilotFullName),
                new ReportParameter("FlightDuration", flight.FlightDuration.ToString()),
                new ReportParameter("Price", flight.Price.ToString()),
                new ReportParameter("Notes", !string.IsNullOrEmpty(flight.Notes) ? flight.Notes : "None"),
                new ReportParameter("NumOfPassengers", reservations.Count.ToString()),
            };
            reportViewer1.LocalReport.SetParameters(rpc);

            var tbl = new FlightReportDataSet.DataTable1DataTable();
            foreach (var reservation in reservations)
            {
                var row = tbl.NewDataTable1Row();
                row.PassengerName = reservation.User.FirstName + " " + reservation.User.LastName;
                row.ReservationDate = reservation.ReservationDate;
                tbl.Rows.Add(row);
            }

            ReportDataSource rds = new ReportDataSource
            {
                Name = "FlightDataSet",
                Value = tbl
            };

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
