using System;
using System.Collections.Generic;
using Issue_13645.ViewModels;
using Issue_13645.Views;
using Xamarin.Forms;

namespace Issue_13645
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
