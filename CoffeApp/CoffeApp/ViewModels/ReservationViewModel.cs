using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CoffeApp.Models;
using CoffeApp.Services;
using Xamarin.Forms;

namespace CoffeApp.ViewModels
{
    public class ReservationViewModel
    {

        public ICommand ReservationCommand { get; private set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TotalPeople { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime FromMiminumDate { get; set; }



        public ReservationViewModel()
        {
            this.FromMiminumDate = DateTime.Now;
            ReservationCommand = new Command(async () => await SendReservation());
        }

        async Task SendReservation()
        {
            Reservation reservation = new Reservation()
            {
                Name = this.Name,
                Email = this.Email,
                Date = this.Date.ToString("yyyy-MM-dd"),
                Phone = this.Phone,
                TotalPeople = int.Parse(this.TotalPeople),
                Time = this.Time.ToString()
            };

            ApiService apiServices = new ApiService();
            bool response = await apiServices.ReservationMenu(reservation);
            if (response != true)
            {
                await Application.Current.MainPage.DisplayAlert("Oops", "Something goes wrong", "Alright");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Hi", "Your table has been resered succesfully", "Alright");
                ClearAllEntry();
            }
        }

        public void ClearAllEntry()
        {
            this.Name = String.Empty;
            this.Email = String.Empty;
            this.Date = DateTime.Now;
            this.Phone = String.Empty;
            this.TotalPeople = String.Empty;
            this.Time = TimeSpan.Zero;
        }
    }
}
