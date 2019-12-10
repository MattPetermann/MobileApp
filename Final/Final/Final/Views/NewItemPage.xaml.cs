using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using Xamarin.Forms;
using Final.Models;
using Newtonsoft.Json.Linq;

namespace Final.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        public Country Country { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            var name = NameEntry.GetValue(Entry.TextProperty).ToString();
            var capital = "";
            var region = "";
            var subRegion = "";
            var population = -1;

            //Make API call to get other properties
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://restcountries-v1.p.rapidapi.com/name/" + name);
            requestMessage.Headers.Add("X-RapidAPI-Key", "72794103f3msh9286887e36e342cp123283jsn367004de6ea2");
            var response = await HttpClient.SendAsync(requestMessage);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                data = data.Trim('[');
                data = data.Trim(']');

                //Serialize the json
                var json = JObject.Parse(data);
                var dictionary = json.ToObject<Dictionary<string, object>>();

                //Get the values
                name = dictionary["name"].ToString();
                capital = dictionary["capital"].ToString();
                region = dictionary["region"].ToString();
                subRegion = dictionary["subregion"].ToString();
                population = int.Parse(dictionary["population"].ToString());
            }

            Country = new Country
            {
                Name = name,
                Capital = capital,
                Region = region,
                SubRegion = subRegion,
                Population = population
            };

            MessagingCenter.Send(this, "AddItem", Country);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}