﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjetTaghtyMobile.Services;
using ProjetTaghtyMobile.Views;

namespace ProjetTaghtyMobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            
            MainPage = new test();
            //accueil = new Accueil();

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
