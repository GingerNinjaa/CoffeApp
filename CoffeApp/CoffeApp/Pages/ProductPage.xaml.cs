using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using CoffeApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ObservableCollection<SubMenu> SubMenus;

        public ProductPage(Menus menus)
        {
            InitializeComponent();



            SubMenus = new ObservableCollection<SubMenu>();
            foreach (var categoryMenu in menus.SubMenus)
            {
                SubMenus.Add(categoryMenu);
            }

            LvProduct.ItemsSource = SubMenus;
        }

      
    }
}