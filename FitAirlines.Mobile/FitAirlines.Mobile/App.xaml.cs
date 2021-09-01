using FitAirlines.Mobile.Services;
using FitAirlines.Mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitAirlines.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            Stripe.StripeConfiguration.ApiKey = "sk_test_51JUygSFZEyvPZ7bheid8q25YYjVrtJ4CtzSuM2LqwN9XPbOeLhzzHzTlVkgrYXy45fXDrCYEmcvvmZUFyy2kYIfq00pdu5m0GJ";

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
