using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Final.Services;
using Final.Views;

namespace Final
{
    public partial class App : Application
    {
        private static CountryDatabase _database;

        public App()
        {
            InitializeComponent();
            DependencyService.Register<CountryDatabase>();
            MainPage = new MainPage();
        }

        public void ChangeTheme(bool highContrast)
        {
            var themeUri = "ThemeResources/" + (highContrast ? "HighContrastTheme" : "DefaultTheme") + ".xaml";
            var source = new Uri(themeUri, UriKind.Relative);
            ResourceDictionary.SetAndLoadSource(source, themeUri, this.GetType().GetTypeInfo().Assembly, null);
        }

        public static CountryDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new CountryDatabase(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CountrySQLite.db3"));
                }
                return _database;
            }
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
