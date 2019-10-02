using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Homework6
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenActivityOne(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PageOne());
        }

        public async void OpenActivityTwo(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PageTwo());
        }

        public async void OpenActivityThree(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PageThree());
        }
    }
}
