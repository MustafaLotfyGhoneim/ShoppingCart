using System;
using System.Globalization;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShoppingCart.Resources;
using ShoppingCart.Views;

namespace ShoppingCart
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LocalizationResourceManager.Current.PropertyChanged += (sender, e) => LangResources.Culture = LocalizationResourceManager.Current.CurrentCulture;
            LocalizationResourceManager.Current.Init(LangResources.ResourceManager);
            LocalizationResourceManager.Current.CurrentCulture = new CultureInfo("ar");
            MainPage = new NavigationPage(new ItemDetails());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
