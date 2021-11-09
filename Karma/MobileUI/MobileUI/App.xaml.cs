﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //FOR DEBUGING VARIOUS PAGES, CHANGE < new ...Page(); > into required page to view it
            var FirstPage = new MainPage();
            Current.MainPage = new NavigationPage(FirstPage);
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
