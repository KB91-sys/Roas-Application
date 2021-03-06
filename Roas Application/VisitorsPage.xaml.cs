﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roas_Application
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisitorsPage : ContentPage
    {
        public VisitorsPage()
        {
            InitializeComponent();
        }

        private void OnCalculateVisitors_Clicked(object sender, EventArgs e) 
        {
            if(!string.IsNullOrEmpty(budget.Text) || !string.IsNullOrEmpty(cpc.Text)) 
            {
                res.Text = "";

                var budgetValue = double.Parse(budget.Text);
                var cpcValue = double.Parse(cpc.Text);

                res.Text = (budgetValue * cpcValue).ToString();            
            }
            else 
            {
                DisplayAlert("Alarm", "Input is not valid", "OK");
            }
        }

        private void OnClearButton_clicked(object sender, EventArgs e)
        {
            budget.Text = "";
            cpc.Text = "";
            res.Text = "";
        }
    }
}