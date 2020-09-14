using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainAppPage : ContentPage
    {
        public MainAppPage()
        {
            InitializeComponent();
            BindingContext = new MainAppViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            this.BackgroundColor = Color.Black;
        }
    }
}