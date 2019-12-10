using Final.Models;

namespace Final.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Country Country { get; set; }
        public ItemDetailViewModel(Country country = null)
        {
            Title = country?.Name;
            Country = country;
        }
    }
}
