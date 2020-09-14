using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using CoffeApp.Services;

namespace CoffeApp.ViewModels
{
    public class CategoryMenuViewModel
    {
        public ObservableCollection<Menus> categoryMenu { get; set; }

        public CategoryMenuViewModel(FrontMenu frontMenu)
        {
            
            categoryMenu = new ObservableCollection<Menus>();

            GetData(frontMenu);
        }

        private async Task GetData(FrontMenu frontMenu)
        {
            foreach (var categoryMenus in frontMenu.menus)
            {
                categoryMenu.Add(categoryMenus);
            }
        }


    }
}
