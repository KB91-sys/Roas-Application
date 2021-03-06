﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roas_Application
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MROIPage : ContentPage
    {
        public MROIPage()
        {
            InitializeComponent();
        }

        private void OnCalculateMROI_Clicked(object sender, EventArgs e) 
        {
            if(!string.IsNullOrEmpty(BudgetEntry.Text) || !string.IsNullOrEmpty(SalesEntry.Text))
            {
                res.Text = "";

                var budgetValue = double.Parse(BudgetEntry.Text);
                var salesValue = double.Parse(SalesEntry.Text);

                var MROIValue = Math.Round((((salesValue - budgetValue) / budgetValue)*100), 2).ToString();

                res.Text = MROIValue + " %";
            }
            else 
            {
                DisplayAlert("Alarm", "Input is not valid", "OK");
            }        
        }

        private void OnClearButton_clicked(object sender, EventArgs e)
        {
            BudgetEntry.Text = "";
            SalesEntry.Text = "";
            res.Text = "";
        }
    }
}