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
    public partial class BaseButton : Button
    {
        public BaseButton()
        {
            InitializeComponent();
            setupStyling();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void setupStyling() 
        {
            // TODO: Add base button styling
            //BackColor = Color.Green;
        }
    }
}
