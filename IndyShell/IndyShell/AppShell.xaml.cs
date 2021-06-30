using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IndyShell
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("smokey", typeof(SmokeDetailPage));
        }
    }
}
