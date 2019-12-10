using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Final.Models;
using SQLite;

namespace Final.Services
{
    public class CountryDatabase
    {
        private static SQLiteAsyncConnection _database;

        public CountryDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Country>().Wait();
        }
        public void AddCountry(Country country)
        {
            _database.InsertAsync(country);
        }

        public Task<List<Country>> GetCountries()
        {
            return _database.Table<Country>().ToListAsync();
        }
    }
}
