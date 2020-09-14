using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using CoffeApp.Services;
using CoffeApp.ViewModels;
using FFImageLoading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstMenu : ContentPage
    {
        private FirstMenuViewModel firstMenuViewModel;

        public FirstMenu()
        {
            InitializeComponent();
             BusyIndicator.IsRunning = true;
            // Connecting context of this page to the our View Model class
            BindingContext = firstMenuViewModel = new FirstMenuViewModel();
             NavigationPage.SetHasNavigationBar(this, false);
             BusyIndicator.IsRunning = false;
        }

        protected override void OnDisappearing()
        {
            this.BackgroundColor = Color.Black;
        }
        
        private void LvFirstMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenu = e.SelectedItem as FrontMenu;
            if (selectedMenu != null)
            {
                Navigation.PushModalAsync(new CategoryMenuPage(selectedMenu));
            }

            ((ListView)sender).SelectedItem = null;
        }


    }
}