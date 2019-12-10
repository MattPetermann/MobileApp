using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;

using Final.Models;
using Final.Services;
using Final.Views;

namespace Final.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Country> Countries { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Countries = new ObservableCollection<Country>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Country>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Country;
                Countries.Add(newItem);
                App.Database.AddCountry(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Countries.Clear();
                var items = App.Database.GetCountries();
                foreach (var item in items.Result)
                {
                    Countries.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}