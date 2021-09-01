using Acr.UserDialogs;
using FitAirlines.Mobile.Models;
using FitAirlines.Mobile.Services;
using FitAirlines.Mobile.Views;
using FitAirlines.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Stripe;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitAirlines.Mobile.ViewModels
{
    public class StripePaymentGatewayViewModel : BindableBase
    {

        #region Variable
        private readonly APIService _serviceUsers = new APIService("Users");

        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;

        private bool _isCarcValid;
        private bool _isTransactionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable

        #region Public Property

        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransactionSuccess
        {
            get { return _isTransactionSuccess; }
            set { SetProperty(ref _isTransactionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        private string amount;

        public string Amount
        {
            get { return amount; }
            set { SetProperty(ref amount, value); }
        }


        #endregion Public Property

        #region Constructor

        public StripePaymentGatewayViewModel()
        {
            CreditCardModel = new CreditCardModel();
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Processing payment..");
                await Task.Run(() =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransactionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");

            }
            finally
            {
                if (IsTransactionSuccess)
                {


                    UserDialogs.Instance.HideLoading();


                    var request = new Model.Requests.UsersAddCreditsRequest()
                    {
                        AddCredits = double.Parse(Amount)
                    };
                    
                    var newCredits = await _serviceUsers.Update<double>(APIService.CurrentUser.UserId, request, "AddCredits");
                    APIService.CurrentUser.Credit = newCredits;

                    CreditCardModel = new CreditCardModel();
                    ExpYear = "";
                    ExpMonth = "";
                    Amount = "";

                    await Shell.Current.GoToAsync("///" + nameof(OffersPage)); // TODO SZEF SHOW PROFILE PAGe

                }
                else
                {

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");

                }
            }

        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = APIService.CurrentUser.ToString(),
                        Currency = "PLN",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
   
        public bool MakePayment(string token)
        {
            try
            {
                var options = new ChargeCreateOptions
                {
                    Amount = (long)(decimal.Parse(Amount) * 100m),
                    Currency = "PLN",
                    Description = $"Payment from {APIService.CurrentUser.FirstName} {APIService.CurrentUser.LastName}",
                    Source = stripeToken.Id,
                    Capture = true,
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                UserDialogs.Instance.Alert("Oops, something went wrong", ex.Message, "OK");
                return false;
            }
        }



        #endregion Method
    }
}