using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IndyShell
{
    public partial class SmokeAlertPage : ContentPage
    {
        public SmokeAlertPage()
        {
            InitializeComponent();
            BindingContext = new SmokeAlertViewModel();
        }
    }
}
