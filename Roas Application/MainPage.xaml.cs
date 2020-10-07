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
        private async void OnBudgetButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BudgetPage());
        }

        private async void OnConversionButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new ConversionPage());
        }

        private async void OnSalesButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new SalePage());
        }

        private async void OnMROIButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new MROIPage());
        }

        private async void OnVisitorsButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new VisitorsPage());
        }
    }
}
