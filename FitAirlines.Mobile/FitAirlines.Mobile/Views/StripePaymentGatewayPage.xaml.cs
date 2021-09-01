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
    public partial class StripePaymentGatewayPage : ContentPage
    {
        private StripePaymentGatewayViewModel model;

        public StripePaymentGatewayPage()
        {
            InitializeComponent();
            BindingContext = model = new ViewModels.StripePaymentGatewayViewModel();

        }

        protected override void OnAppearing()
        {
            Submit_Button.IsEnabled = false;
            ErrorLabel_CardNumber.IsVisible = false;
            ErrorLabel_Cvv.IsVisible = false;
            ErrorLabel_Month.IsVisible = false;
            ErrorLabel_Year.IsVisible = false;
            ErrorLabel_Amount.IsVisible = false;

        }
        private void CardNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(CardNumber.Text))
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Card number is required.";
            }
            else if (CardNumber.Text.Length > 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                CardNumber.Text = RemoveLastCharacter(CardNumber.Text);
                ErrorLabel_CardNumber.Text = "Invalid card number";
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
            UpdateSubmitButton();

        }
        private void Amount_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(Amount.Text))
            {
                ErrorLabel_Amount.Text = "Amount is required.";
                ErrorLabel_Amount.IsVisible = true;
            }
            else if (!decimal.TryParse(Amount.Text, out decimal result))
            {
                ErrorLabel_Amount.Text = "Amount is not valid.";

                ErrorLabel_Amount.IsVisible = true;
            }
            else if (result < 5.0m)
            {
                ErrorLabel_Amount.Text = "Minimum payment amount is 5.00 PLN.";

                ErrorLabel_Amount.IsVisible = true;
            }
            else
            {
                ErrorLabel_Amount.IsVisible = false;
            }

            UpdateSubmitButton();


        }
        private void Amount_Completed(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(Amount.Text))
            {
                ErrorLabel_Amount.IsVisible = true;
                ErrorLabel_Amount.Text = "Amount is required.";

            }
            else if (!decimal.TryParse(Amount.Text, out decimal result))
            {
                ErrorLabel_Amount.Text = "Amount is not valid.";
                ErrorLabel_Amount.IsVisible = true;

            }
            else if (result < 5.0m)
            {
                ErrorLabel_Amount.Text = "Minimum payment amount is 5.00 PLN.";
                ErrorLabel_Amount.IsVisible = true;
            }
            else
            {
                ErrorLabel_Amount.IsVisible = false;
                Amount.Unfocus();
                Submit_Button.Focus();
            }
            UpdateSubmitButton();
        }
        private void CardNumber_Completed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(CardNumber.Text) || CardNumber.Text.Length != 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Invalid card number";

            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
                CardNumber.Unfocus();
                Month.Focus();
            }
            UpdateSubmitButton();

        }

        private void Month_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Month.Text))
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Month is required.";
            }
            else if (Month.Text.Length > 2)
            {
                Month.Text = RemoveLastCharacter(Month.Text);
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Invalid month.";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
            }
            UpdateSubmitButton();

        }
        private void Month_Completed(object sender, System.EventArgs e)
        {
            Month.Unfocus();
            Year.Focus();
        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Year.Text))
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Year is required.";
            }
            else if (Year.Text.Length > 2)
            {
                Year.Text = RemoveLastCharacter(Year.Text);
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Invalid year.";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
            }
            UpdateSubmitButton();

        }
        private void Year_Completed(object sender, System.EventArgs e)
        {
            Year.Unfocus();
            Cvv.Focus();
        }

        private void Cvv_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Cvv.Text))
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "CVV is required.";
            }
            else if (Cvv.Text.Length < 3)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Invalid Cvv.";
            }
            else if (Cvv.Text.Length > 3)
            {
                Cvv.Text = RemoveLastCharacter(Cvv.Text);
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Invalid CVV.";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
            }
            UpdateSubmitButton();
        }
        private void Cvv_Completed(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(Cvv.Text))
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "CVV is required.";
            }
            else if (Cvv.Text.Length < 3)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Invalid Cvv.";
            }
            else if (Cvv.Text.Length > 3)
            {
                Cvv.Text = RemoveLastCharacter(Cvv.Text);
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Invalid Cvv.";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
                Cvv.Unfocus();
                Amount.Focus();
            }
            UpdateSubmitButton();

        }

        private void UpdateSubmitButton()
        {
            if (ErrorLabel_CardNumber.IsVisible || ErrorLabel_Cvv.IsVisible || ErrorLabel_Month.IsVisible || ErrorLabel_Year.IsVisible || ErrorLabel_Amount.IsVisible)
            {
                Submit_Button.IsEnabled = false;
            }
            else
            {
                Submit_Button.IsEnabled = true;
            }
        }
        private string RemoveLastCharacter(string str)
        {
            int l = str.Length;
            string text = str.Remove(l - 1, 1);
            return text;
        }
    }
}