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
using Microsoft.Reporting.WinForms;

namespace FitAirlines.UI
{
    public partial class FlightReportForm : BaseForm
    {
        private readonly Flights flight;

        public FlightReportForm(Model.Flights flight)
        {
            InitializeComponent();
            this.flight = flight;
        }

        private void FlightReportForm_Load(object sender, EventArgs e)
        {
            //ReportParameterCollection rpc = new ReportParameterCollection();
            //rpc.Add(new ReportParameter("ImePrezime", $"{korisnik.Ime} {korisnik.Prezime}"));
            //rpc.Add(new ReportParameter("Indeks", korisnik.KorisnickoIme));
            //// Dodaj parametre u report
            //reportViewer1.LocalReport.SetParameters(rpc);

            // Lista objekata
            List<object> list = new List<object>();
            list.Add(new
            {
                AddedByUserId = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Price = 123
            });

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "FlightDataSet";
            rds.Value = list;

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
