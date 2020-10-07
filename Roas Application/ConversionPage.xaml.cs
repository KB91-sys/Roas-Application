using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace Roas_Application
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversionPage : ContentPage
    {
        public ConversionPage()
        {
            InitializeComponent();
        }

        private void OnCalculateButton_clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(VisitorsEntry.Text) || !string.IsNullOrEmpty(ConversionRateEntry.Text)) 
            {
                res.Text = "";

                var visitors = double.Parse(VisitorsEntry.Text);
                var conversionsRate = double.Parse(ConversionRateEntry.Text);

                var conversionInDecimal = conversionsRate/100;

                res.Text = (visitors * conversionInDecimal).ToString();
            }
            else 
            {
                DisplayAlert("Alert", "Input is not valid", "OK");
            }
        }

        private void OnClearButton_clicked(object sender, EventArgs e)
        {
            VisitorsEntry.Text = "";
            ConversionRateEntry.Text = "";
            res.Text = "";
        }
    }
}