using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCart.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetails : ContentPage
    {
        public ItemDetails()
        {
            InitializeComponent();
        }
        private async void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingCartPage());
        }
    }
}