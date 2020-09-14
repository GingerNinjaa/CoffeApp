using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CoffeApp.ViewModels
{
    public class InfoViewModel
    {
        public Command LaunchLinkedinCommand { get; }
        public Command LaunchWebsiteCommand { get; }
        public Command CallMe { get; }
        

        public InfoViewModel()
        {
            LaunchWebsiteCommand = new Command(LaunchLinkedin);
            LaunchLinkedinCommand = new Command(LaunchWebsite);
            CallMe = new Command(LaunchPhoneDialer);

        }

        void LaunchLinkedin()
        {
            try
            {
                Device.OpenUri(new Uri("https://www.linkedin.com/in/damian-lewandowski-dev/"));
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Oops", "Something goes wrong", "Alright");
            }
        }

        void LaunchWebsite()
        {
            try
            {
                Device.OpenUri(new Uri("https://dlewandowski.pl/"));
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Oops", "Something goes wrong", "Alright");
            }
        }

        void LaunchPhoneDialer()
        {
            try
            {
                PhoneDialer.Open("727934129");
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Oops", "Something goes wrong", "Alright");
            }
        }
    }
}
