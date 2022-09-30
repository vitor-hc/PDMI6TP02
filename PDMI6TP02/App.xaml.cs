﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;




[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PDMI6TP02
{
    public partial class App : Application
    {
        public App()
        {


            MainPage = new NavigationPage(new Views.Principal());
            InitializeComponent();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
