﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Issue_13645.Services;
using Issue_13645.Views;

namespace Issue_13645
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
