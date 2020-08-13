using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void TabFacebook_OnTappedebook_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/czarussss?ref=bookmarks"));
        }

        private void TabTwitter_OnTappedtter_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/in/damian-lewandowski-dev/"));
        }

        private void TabInstagram_OnTappedtagram_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://dlewandowski.pl/"));
        }

        private void TabYoutube_OnTappedbe_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://dlewandowski.pl/"));
        }

        private void TabPhone_OnTapped_OnTapped(object sender, EventArgs e)
        {
            PhoneDialer.Open("727934129");
        }
    }
}