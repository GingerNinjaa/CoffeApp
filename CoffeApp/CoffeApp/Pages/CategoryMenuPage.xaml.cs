using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryMenuPage : ContentPage
    {
        public ObservableCollection<Menus> CategoryMenus;

        public CategoryMenuPage(FrontMenu frontMenu)
        {
            InitializeComponent();
            


            CategoryMenus = new ObservableCollection<Menus>();
            foreach (var categoryMenu in frontMenu.menus)
            {
                CategoryMenus.Add(categoryMenu);

            }

            LvCategoryMenu.ItemsSource = CategoryMenus;
        }

        private void LvCategoryMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenu = e.SelectedItem as Menus;
            if (selectedMenu != null)
            {

             //   Navigation.PushAsync(new ProductPage(selectedMenu),false);
                Navigation.PushModalAsync(new ProductPage(selectedMenu));

            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}