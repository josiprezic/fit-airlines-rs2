using FitAirlines.UI.Properties;

namespace FitAirlines.UI
{
    public partial class MainMenuForm : BaseForm
    {
        protected override bool ShouldResize()
        {
            return false;
        }

        public MainMenuForm()
        {
            InitializeComponent();
        }

        protected override void SetupStrings()
        {
            Text = "FIT Airlines";
            offersButton.Text = Resources.MainMenu_Offers;
            reservationsButton.Text = Resources.MainMenu_Reservations;
            usersButton.Text = Resources.MainMenu_Users;
            flightsButton.Text = Resources.MainMenu_Flights;
        }

        private void offersButton_Click(object sender, System.EventArgs e)
        {
            ShowNewForm<OffersForm>();
        }

        private void flightsButton_Click(object sender, System.EventArgs e)
        {
            ShowNewForm<FlightsForm>();
        }

        private void reservationsButton_Click(object sender, System.EventArgs e)
        {
            ShowNewForm<ReservationsForm>();
        }

        private void usersButton_Click(object sender, System.EventArgs e)
        {
            ShowNewForm<UsersForm>();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ShowNewForm<SettingsForm>();
        }
    }
}