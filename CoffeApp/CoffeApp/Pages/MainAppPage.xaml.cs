using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           
        }

        protected override void OnAppearing()
        {
            this.BackgroundColor = Color.Black;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage(),false);
           
        }
    }
}