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
    public partial class RecommendedDestinationsPage : ContentPage
    {
        private readonly RecommendedDestinationsViewModel _viewModel;

        public RecommendedDestinationsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new RecommendedDestinationsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}