using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI.CustomViews
{
    public partial class MainMenuButton : BaseButton
    {

        //
        // MARK: - Constructors
        //

        public MainMenuButton()
        {
            InitializeComponent();
        }
        
        //
        // MARK: - Public methods
        //

        public override string Text {
            get => base.Text;
            set => base.Text = value.ToUpper();
        }

        //
        // MARK: - Protected methods
        //

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Configure();
        }

        protected void SetupStyling()
        {
            BackColor = Color.Blue;
            ForeColor = Color.White;
            Font = new Font("Microsoft Sans Serif", 15);
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
            
        }
    }
}
