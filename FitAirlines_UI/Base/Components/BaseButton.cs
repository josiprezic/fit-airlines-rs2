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
    public partial class BaseButton : Button
    {
        
        //
        // MARK: - Constructors
        //

        public BaseButton()
        {
            InitializeComponent();
        }

        //
        // MARK: - Protected methods
        //

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Configure();
        }

        protected virtual void SetupStyling()
        {
            // TODO: JR
        }

        //
        // MARK: - Private methods
        //

        void Configure()
        {
            BaseSetup();
            SetupStyling();
        }

        void BaseSetup()
        {
            // TODO: JR
        }
    }
}
