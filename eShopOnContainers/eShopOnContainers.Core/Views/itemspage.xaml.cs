using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class itemspage : ContentPage
    {
        public itemspage()
        {
            InitializeComponent();
        }
        private async void Deneme13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void deneme1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Telefon());
        }
        private async void deneme2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TV());
        }
        private async void deneme3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new beyaz());
        }
        private async void deneme4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CatalogView());
        }
    }
}