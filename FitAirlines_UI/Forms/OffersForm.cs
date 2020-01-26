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
    public partial class OffersForm : BaseDataGridViewForm
    {
        public OffersForm()
        {
            InitializeComponent();
        }

        protected override void SetupStrings()
        {
            Text = Resources.Offers_FormName;
        }
    }
}
