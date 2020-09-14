using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Pages;
using Xamarin.Forms;

namespace CoffeApp.ViewModels
{
    public class MainAppViewModel 
    {
        public INavigation Navigation { get; set; }
        public Command OpenMenuPage { get; }

        public MainAppViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.OpenMenuPage = new Command(async () => await GotoMenuPage());
        }
        public async Task GotoMenuPage()
        {
            await Navigation.PushModalAsync(new HomePage());
        }
        
    }
}