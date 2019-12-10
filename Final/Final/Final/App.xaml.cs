using System;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Final.Services;
using Final.Views;

namespace Final
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        public void ChangeTheme(bool highContrast)
        {
            var themeUri = "ThemeResources/" + (highContrast ? "HighContrastTheme" : "DefaultTheme") + ".xaml";
            var source = new Uri(themeUri, UriKind.Relative);
            ResourceDictionary.SetAndLoadSource(source, themeUri, this.GetType().GetTypeInfo().Assembly, null);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
