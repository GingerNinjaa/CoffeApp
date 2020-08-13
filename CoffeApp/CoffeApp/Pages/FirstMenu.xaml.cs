using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using CoffeApp.Services;
using FFImageLoading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstMenu : ContentPage
    {
        public ObservableCollection<FrontMenu> frontMenus;



        public FirstMenu()
        {
            InitializeComponent();
            frontMenus = new ObservableCollection<FrontMenu>();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnDisappearing()
        {

        }

        protected override async void OnAppearing()
        {
 
            base.OnAppearing();
            if (SendApi.First)
            {
                ApiService apiServices = new ApiService();
                var menus = await apiServices.GetMainMenu();

                foreach (var menu in menus)
                {
                    frontMenus.Add(menu);
                }

                LvFirstMenu.ItemsSource = frontMenus;
                BusyIndicator.IsRunning = false;
            }
           
            SendApi.First = false;
        }
        

        private void LvFirstMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenu = e.SelectedItem as FrontMenu;
            if (selectedMenu != null)
            {
                Navigation.PushAsync(new CategoryMenuPage(selectedMenu),true);
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}