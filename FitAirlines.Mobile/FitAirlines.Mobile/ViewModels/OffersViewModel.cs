using FitAirlines.Mobile.Models;
using FitAirlines.Mobile.Services;
using FitAirlines.Mobile.Views;
using FitAirlines.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitAirlines.Mobile.ViewModels
{
    public class OffersViewModel : BaseViewModel
    {
        private readonly APIService _serviceOffers = new APIService("Offers");

        public ObservableCollection<Offers> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command<Offers> ItemTapped { get; }
        public Command SearchCommand { get; }

        public OffersViewModel()
        {
            Title = "Offers";
            Items = new ObservableCollection<Offers>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ItemTapped = new Command<Offers>(OnItemSelected);
            SearchCommand = new Command(OnSearch);
        }

        private async Task ExecuteLoadItemsCommand()
        {
            if (IsRequesting)
                return;

            IsRequesting = true;
            IsBusy = true;

            try
            {
                var request = new Model.Requests.OffersSearchRequest
                {
                    Name = SearchTerm,
                    ShowOnlyActive = true,
                    LoadPictures = true
                };

                var items = await _serviceOffers.Get<List<Offers>>(request);
                Items.Clear();
                foreach (var item in items)
                {
                    item.ViewportWidth = (int)Math.Truncate(Xamarin.Forms.Application.Current.MainPage.Width); ;
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
                IsRequesting = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            IsRequesting = false;
        }


        async void OnItemSelected(Offers item)
        {
            if (item == null)
            {
                return;
            }

            // This will push the OfferDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.OfferId}");
        }

        private void OnSearch(object obj)
        {
            LoadItemsCommand.Execute(null);
        }

        private string _searchTerm;

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                if (_searchTerm != value)
                {
                    SetProperty(ref _searchTerm, value);
                }
            }
        }

    }
}