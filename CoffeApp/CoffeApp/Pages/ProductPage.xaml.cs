using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class ProductPage : ContentPage
    {
       // public ObservableCollection<SubMenu> ItemInMenu;

        public ProductPage(Menus menus)
        {
            InitializeComponent();
            BindingContext = new ProductViewModel(menus);
        }

      
    }
}