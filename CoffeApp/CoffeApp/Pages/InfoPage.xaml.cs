using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.ViewModels;
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
            BindingContext  = new InfoViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }


    }
}