using System;
using CoffeApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
             MainPage = new NavigationPage(new HomePage());

        }

        protected override void OnStart()
        {
            SendApi.First = true;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            MainPage = new NavigationPage(new HomePage());
        }
    }

    static class SendApi
    {
        // Prevent overloop api
        public static bool First;
    }
}
