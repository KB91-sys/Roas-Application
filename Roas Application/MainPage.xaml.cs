using System;
using Xamarin.Forms;

namespace Roas_Application
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnConversionButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new ConversionPage());
        }
    }
}
