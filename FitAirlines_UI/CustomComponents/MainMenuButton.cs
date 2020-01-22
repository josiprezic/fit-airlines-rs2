using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines_UI.CustomViews
{
    public partial class MainMenuButton : BaseButton
    {
        public MainMenuButton()
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
            BackColor = Color.Blue;
            ForeColor = Color.White;
            Font = new Font("Microsoft Sans Serif", 20);
        }
    }
}
