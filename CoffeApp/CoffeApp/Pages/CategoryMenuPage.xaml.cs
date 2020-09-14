using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using CoffeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryMenuPage : ContentPage
    {
        public CategoryMenuPage(FrontMenu frontMenu)
        {
            InitializeComponent();
            BindingContext = new CategoryMenuViewModel(frontMenu);
        }

        private void LvCategoryMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenu = e.SelectedItem as Menus;
            if (selectedMenu != null)
            {
                Navigation.PushModalAsync(new ProductPage(selectedMenu));
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}