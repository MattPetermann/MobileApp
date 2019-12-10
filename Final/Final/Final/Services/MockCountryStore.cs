using System.Collections.Generic;
using Final.Models;

namespace Final.Services
{
    public class MockCountryStore
    {
        private static List<Country> _countries { get; set; }

        public static List<Country> Countries => _countries ?? (_countries = new List<Country>());

        public static void AddCountry(Country country)
        {
            Countries.Add(country);
        }
    }
}