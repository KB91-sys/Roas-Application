using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roas_Application
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BudgetPage : ContentPage
    {
        public BudgetPage()
        {
            InitializeComponent();
        }
        private async void OnNextButton_Clicked(object sender, EventArgs e)
        {
            //var budgetValue = double.Parse(budget.Text);

            if (string.IsNullOrEmpty(budget.Text)==false)
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alert", "Input is not valid", "OK");
            }
        }
    }
}