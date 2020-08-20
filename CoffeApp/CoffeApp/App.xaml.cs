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
           //  MainPage = new NavigationPage(new HomePage());
           MainPage = new NavigationPage(new MainAppPage());

        }

        protected override void OnStart()
        {
       
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            //  MainPage = new NavigationPage(new HomePage());
            MainPage = new NavigationPage(new MainAppPage());
        }
    }


}
