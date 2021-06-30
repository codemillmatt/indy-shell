using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IndyShell
{
    [QueryProperty(nameof(CityName), "cityName")]
    public partial class SmokeDetailPage : ContentPage
    {
        public string CityName {
            set
            {
                cityNameLabel.Text = $"{value} is smokey";
            }
        }

        public SmokeDetailPage()
        {
            InitializeComponent();            
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
