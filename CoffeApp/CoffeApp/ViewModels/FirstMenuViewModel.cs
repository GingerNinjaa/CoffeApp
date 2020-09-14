using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using CoffeApp.Services;
using Xamarin.Forms;

namespace CoffeApp.ViewModels
{
    public class FirstMenuViewModel
    {

        public ObservableCollection<FrontMenu> frontMenus { get; set; }
        bool isBusy = true;

        public FirstMenuViewModel()
        {
            frontMenus = new ObservableCollection<FrontMenu>();
            GetData();
            IsBusy = true;
        }
        

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; }
        }

        public async Task GetData()
        {
           //var frontMenus = new ObservableCollection<FrontMenu>();
            this.IsBusy = true;
            
            ApiService apiServices = new ApiService();
            var menus = await apiServices.GetMainMenu();
            foreach (var menu in menus)
            {
                frontMenus.Add(menu);
            }
            this.IsBusy = false;
        }


    }
}
