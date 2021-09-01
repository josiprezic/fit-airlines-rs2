using FitAirlines.Mobile.Services;
using FitAirlines.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FitAirlines.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        
        private readonly APIService _serviceUsers = new APIService("Users");
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            APIService.Username = Email;
            APIService.Password = Password;
            try
            {
                APIService.CurrentUser = await _serviceUsers.Get<Model.Users>(null, "MyProfile");

                if (APIService.CurrentUser != null)
                {
                    if (APIService.CurrentUser.UserRole.Title != "FIT Member")
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "You are not allowed to log into this application.", "OK");
                    }
                    else
                    {
                        Application.Current.MainPage = new AppShell();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        #region Properties
        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        #endregion
    }
}
