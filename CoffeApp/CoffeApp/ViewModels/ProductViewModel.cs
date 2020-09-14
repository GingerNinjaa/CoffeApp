using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;

namespace CoffeApp.ViewModels
{
    public class ProductViewModel
    {
        public ObservableCollection<SubMenu> ItemInMenu { get; set; }

        public ProductViewModel(Menus menus)
        {
            ItemInMenu = new ObservableCollection<SubMenu>();
            GetData(menus);
        }

        private async Task GetData(Menus menus)
        {
            foreach (var item in menus.SubMenus)
            {
                ItemInMenu.Add(item);
            }
        }
    }

}

