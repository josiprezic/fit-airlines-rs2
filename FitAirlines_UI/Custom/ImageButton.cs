using FitAirlines.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    public partial class ImageButton : BaseButton
    {
        //
        // MARK: - Constructors
        //

        public ImageButton()
        {
            InitializeComponent();
        }

        public ImageButton(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        //
        // MARK: - Protected methods
        //

        protected override void SetupStyling()
        {
            TextImageRelation = TextImageRelation.ImageBeforeText;
        }
    }
}
