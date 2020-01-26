using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitAirlines_UI.Properties;

namespace FitAirlines_UI
{
    public partial class SearchNewEditControl : UserControl
    {
        public SearchNewEditControl()
        {
            InitializeComponent();
        }

        private void SearchNewEditControl_Load(object sender, EventArgs e)
        { 

            // TODO: JR update icons for buttons below

            searchImageButton.Image = Resources.Icon_Add;
            searchImageButton.Text = Resources.Generic_Search;

            newImageButton.Image = Resources.Icon_Add;
            newImageButton.Text = Resources.Generic_Add;

            editImageButton.Image = Resources.Icon_Add;
            editImageButton.Text = Resources.Generic_Edit;
        }
    }
}
