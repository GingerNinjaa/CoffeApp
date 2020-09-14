using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using CoffeApp.Services;
using CoffeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservarionPage : ContentPage
    {
        public ReservarionPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new ReservationViewModel();
        }
    }
}