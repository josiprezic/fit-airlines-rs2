using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAirlines_UI
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
        // 
        //

        protected override void SetupStyling() 
        {
            // TODO: JR
            Image = System.Drawing.SystemIcons.Warning.ToBitmap();
        }
    }
}
