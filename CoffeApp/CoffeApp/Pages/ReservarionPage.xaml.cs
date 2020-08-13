using System;
using System.Collections.Generic;
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
    public partial class ReservarionPage : ContentPage
    {
        public ReservarionPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void BtnReservationButon_OnClickedrvationButon_OnClicked(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation()
            {
                Name = EntName.Text,
                Email = EntEmail.Text,
                Date = DpBookingDate.Date.ToString("yyyy-MM-dd"),
                Phone = EntPhone.Text,
                TotalPeople = int.Parse(EntTotalPeople.Text),
                Time = TpBookingTime.Time.ToString()

            };
            ApiService apiServices = new ApiService();
            bool response = await apiServices.ReservationMenu(reservation);
            if (response != true)
            {
                await DisplayAlert("Oops", "Something goes wrong", "Alright");
            }
            else
            {
                await DisplayAlert("Hi", "Your table has been resered succesfully", "Alright");
            }
        }
    }
}