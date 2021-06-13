using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace FitAirlines.Mobile.UWP
{
    public sealed partial class MainPage
    {
        private const int WIDTH = 500;
        private const int HEIGHT = 900;

        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new FitAirlines.Mobile.App());
        }

        private void WindowsPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if ((this.Width != WIDTH) || (this.Height != Height))
            {
                this.Width = WIDTH;
                this.Height = HEIGHT;
            }
        }
    }
}
