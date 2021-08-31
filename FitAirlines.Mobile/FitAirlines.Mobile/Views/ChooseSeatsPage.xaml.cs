using FitAirlines.Mobile.Services;
using FitAirlines.Mobile.ViewModels;
using FitAirlines.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitAirlines.Mobile.Views
{
    public partial class ChooseSeatsPage : ContentPage
    {

        private readonly ChooseSeatsViewModel _viewModel;

        private Button seatDeparture;
        private Button seatArrival;
        private List<Button> buttonList = new List<Button>();
        private List<ReservedSeats> reservedSeats;

        private bool isDeparture = true;

        const int columns = 6;
        const int rows = 15;
        const int capacity = rows * columns;

        public ChooseSeatsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ChooseSeatsViewModel();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _viewModel.LoadFlight();

            SetupHeaderGrid();
            SetupSeatsGrid();

            reservedSeats = await _viewModel.GetReservedSeats();
            UpdateSeatAvailabilty();
        }

        private void UpdateSeatAvailabilty()
        {
            foreach (var btn in buttonList)
            {
                if ((isDeparture && btn != seatDeparture) || (!isDeparture && btn != seatArrival))
                    btn.BackgroundColor = Color.Gray;
            }

            foreach (var btn in buttonList)
            {
                var currentSeatIndex = SeatStringToIndex(btn.ClassId);

                var query = reservedSeats.AsQueryable();
                if (isDeparture)
                    query = query.Where(x => x.Direction == "1");
                else
                    query = query.Where(x => x.Direction == "2");

                if (query.Any(x => x.SeatIndex == currentSeatIndex))
                {
                    btn.BackgroundColor = Color.Red;
                }
            }
        }

        private void SetupSeatsGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                AddRowOfSeats(i, columns);
            }

        }

        public int SeatStringToIndex(string seat)
        {
            int row = int.Parse(seat.Substring(0, seat.Length - 1)) - 1;
            int column = Convert.ToChar(seat.Substring(seat.Length - 1)) - 65;

            return (row * columns) + column;
        }
        public string SeatIndexToString(int row, int column)
        {
            return row + 1 + Convert.ToChar(65 + column).ToString();
        }

        private void AddRowOfSeats(int currentRow, int columns)
        {
            int half = columns / 2;

            for (int i = 0; i < columns; i++)
            {
                string SeatString = SeatIndexToString(currentRow, i);

                var btn = new Button
                {
                    ClassId = SeatString,
                    FontSize = 24,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    BackgroundColor = Color.Gray,
                    BorderWidth = 3,
                    CornerRadius = 5,
                    BorderColor = Color.Black,
                    WidthRequest = 50,
                    HeightRequest = 50,

                };
                buttonList.Add(btn);
                btn.Clicked += Btn_Clicked;
                seatsGrid.Children.Add(btn, i >= half ? i + 1 : i, currentRow);

                if (FlightReservationViewModel.SeatArrival != -1)
                {
                    int SelectedSeatRow = FlightReservationViewModel.SeatArrival / columns;
                    int SelectedSeatColumn = FlightReservationViewModel.SeatArrival % columns;

                    if (SelectedSeatRow == currentRow && SelectedSeatColumn == i)
                    {
                        seatArrival = btn;
                    }
                }

                if (FlightReservationViewModel.SeatDeparture != -1)
                {
                    int SelectedSeatRow = FlightReservationViewModel.SeatDeparture / columns;
                    int SelectedSeatColumn = FlightReservationViewModel.SeatDeparture % columns;

                    if (SelectedSeatRow == currentRow && SelectedSeatColumn == i)
                    {
                        seatDeparture = btn;
                        ActivateSeat(seatDeparture);
                    }
                }
            }

            seatsGrid.Children.Add(new Label
            {
                Text = (currentRow + 1).ToString(),
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, half, currentRow);

        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.BackgroundColor == Color.Red)
                return;

            if (isDeparture)
            {
                ResetSeat(seatDeparture);
                seatDeparture = btn;
            }
            else
            {
                ResetSeat(seatArrival);
                seatArrival = btn;
            }
            ActivateSeat(btn);

        }

        private void ResetSeat(Button seat)
        {
            if (seat != null)
            {
                seat.Text = "";
                seat.BackgroundColor = Color.Gray;
            }
        }

        private void ButtonDeparture_Clicked(object sender, EventArgs e)
        {
            if (isDeparture)
                return;

            isDeparture = true;
            UpdateSeatAvailabilty();
            ResetSeat(seatArrival);
            ActivateSeat(seatDeparture);
        }

        private void ButtonArrival_Clicked(object sender, EventArgs e)
        {
            if (!isDeparture)
                return;

            isDeparture = false;
            UpdateSeatAvailabilty();
            ResetSeat(seatDeparture);
            ActivateSeat(seatArrival);
        }

        private void ActivateSeat(Button seat)
        {
            if (seat != null)
            {
                seat.Text = "✓";
                seat.BackgroundColor = Color.Green;
            }
            UpdateChosenSeat();
        }

        private void UpdateChosenSeat()
        {
            if (isDeparture)
            {
                if (seatDeparture != null)
                {
                    _viewModel.ChosenSeat = seatDeparture.ClassId;
                    FlightReservationViewModel.SeatDeparture = SeatStringToIndex(seatDeparture.ClassId);
                    return;
                }
            }
            else
            {
                if (seatArrival != null)
                {
                    _viewModel.ChosenSeat = seatArrival.ClassId;
                    FlightReservationViewModel.SeatArrival = SeatStringToIndex(seatArrival.ClassId);
                    return;
                }
            }

            _viewModel.ChosenSeat = "N/A";
        }

        private void SetupHeaderGrid()
        {
            gridHeader.Children.Add(new Label
            {
                Text = "A",
                HorizontalTextAlignment = TextAlignment.Center
            }, 0, 0);
            gridHeader.Children.Add(new Label
            {
                Text = "B",
                HorizontalTextAlignment = TextAlignment.Center
            }, 1, 0);
            gridHeader.Children.Add(new Label
            {
                Text = "C",
                HorizontalTextAlignment = TextAlignment.Center
            }, 2, 0);
            gridHeader.Children.Add(new Label
            {
                Text = "D",
                HorizontalTextAlignment = TextAlignment.Center
            }, 4, 0);
            gridHeader.Children.Add(new Label
            {
                Text = "E",
                HorizontalTextAlignment = TextAlignment.Center
            }, 5, 0);
            gridHeader.Children.Add(new Label
            {
                Text = "F",
                HorizontalTextAlignment = TextAlignment.Center
            }, 6, 0);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PopAsync();
        }
    }
}