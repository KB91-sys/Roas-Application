using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roas_Application
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SalePage : ContentPage
    {
        public SalePage()
        {
            InitializeComponent();
        }

        private void OnCalculateButton_Clicked(object sender, EventArgs e)
        {
            res.Text = "";

            var aovValue = double.Parse(aov.Text);
            var conversionValue = double.Parse(conversions.Text);

            res.Text = "Sales value: " + (aovValue * conversionValue).ToString();
        }

        private void OnClearButton_clicked(object sender, EventArgs e)
        {
            aov.Text = "";
            conversions.Text = "";
            res.Text = "";
        }

    }
}