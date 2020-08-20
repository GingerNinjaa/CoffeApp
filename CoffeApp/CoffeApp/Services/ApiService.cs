using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoffeApp.Models;
using Newtonsoft.Json;

namespace CoffeApp.Services
{
   public class ApiService
    {
        public async Task<List<FrontMenu>> GetMainMenu()
        {
            var client = new HttpClient();

            //Client send get request                                
             var response = await client.GetStringAsync("https://gingerninjaaapiservice.pl/api/OldBrickyard/all");

             //deserializacja JSON
            return JsonConvert.DeserializeObject<List<FrontMenu>>(response);

        }

        public async Task<bool> ReservationMenu(Reservation reservation)
        {

            var client = new HttpClient();

            //serializacja
            var json = JsonConvert.SerializeObject(reservation);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //post request
            var response = await client.PostAsync("https://gingerninjaaapiservice.pl/api/OldBrickyard/post", content);
            return response.IsSuccessStatusCode;
        }
    }
}
