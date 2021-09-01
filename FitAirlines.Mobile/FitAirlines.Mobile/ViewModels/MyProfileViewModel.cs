using FitAirlines.Mobile.Services;
using FitAirlines.Mobile.Views;
using FitAirlines.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FitAirlines.Mobile.ViewModels
{
    public class MyProfileViewModel : BaseViewModel
    {

        private readonly APIService _serviceUsers = new APIService("Users");

        private Model.Requests.UsersUpdateRequest user;

        private byte[] profilePicture;


        public MyProfileViewModel()
        {
            SaveCommand = new Command(async () => await OnSaveClicked());
        }

        private async Task OnSaveClicked()
        {
            User.Picture = ProfilePicture;

            var entity = await _serviceUsers.Update<Users>(APIService.CurrentUser.UserId, User);
            if (entity != null)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Profile changes were saved successfully.", "OK");
                if (!string.IsNullOrEmpty(User.Password))
                    APIService.Password = User.Password;

                APIService.CurrentUser = entity;
            }

        }

        public ICommand SaveCommand { get; }


        public async Task Init()
        {
            await LoadUser();
        }

        private async Task LoadUser()
        {
            Users CurrentUser = await _serviceUsers.Get<Users>(null, "MyProfile");
            User = new Model.Requests.UsersUpdateRequest
            {
                BirthDate = CurrentUser.BirthDate,
                ContactNumber = CurrentUser.ContactNumber,
                Email = CurrentUser.Email,
                FirstName = CurrentUser.FirstName,
                LastName = CurrentUser.LastName,
                Gender = CurrentUser.Gender,
                MembershipTypeId = CurrentUser.MembershipTypeId,
                IsActive = CurrentUser.IsActive,
                Credit = CurrentUser.Credit,
                UserRoleId = CurrentUser.UserRoleId
            };

            ProfilePicture = CurrentUser.Picture;
        }
        #region properties
        
        public byte[] ProfilePicture
        {
            get
            {
                return this.profilePicture;
            }

            set
            {
                if (this.profilePicture == value)
                {
                    return;
                }

                this.SetProperty(ref this.profilePicture, value);
            }
        }
        
        public Model.Requests.UsersUpdateRequest User
        {
            get
            {
                return this.user;
            }

            set
            {
                if (this.user == value)
                {
                    return;
                }

                this.SetProperty(ref this.user, value);
            }
        }



        #endregion
    }

}