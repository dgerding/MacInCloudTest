using System;
using System.Collections.Generic;
using MacInCloudTest.ViewModels;
using MacInCloudTest.Views;
using Xamarin.Forms;

namespace MacInCloudTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
