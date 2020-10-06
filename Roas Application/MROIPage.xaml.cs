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
            var budgetValue = double.Parse(BudgetEntry.Text);
            var salesValue = double.Parse(SalesEntry.Text);

            var MROIValue = Math.Round((((salesValue - budgetValue) / budgetValue)*100), 2).ToString();

            res.Text = MROIValue + " %";
        }
    }
}