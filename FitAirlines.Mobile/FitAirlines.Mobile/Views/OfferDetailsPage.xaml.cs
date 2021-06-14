using FitAirlines.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitAirlines.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferDetailsPage : ContentPage
    {
        private readonly OfferDetailsViewModel _viewModel;

        public OfferDetailsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new OfferDetailsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}