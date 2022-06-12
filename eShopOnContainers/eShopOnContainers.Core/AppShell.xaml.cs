using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.ViewModels.Base;
using eShopOnContainers.Core.ViewModels.Helpers;
using eShopOnContainers.Core.Views;
using Xamarin.Forms;

namespace eShopOnContainers.Core
{
    public partial class AppShell : Shell
    {
        public AppShell ()
        {
            //InitializeRouting ();
            InitializeComponent ();

            //var settingsService = ViewModelLocator.Resolve<ISettingsService> ();

            /*if (string.IsNullOrEmpty (settingsService.AuthAccessToken))
            {
                this.GoToAsync("//Login");
            }*/

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (!Auth.IsAuthenticated())
            {
                await Task.Delay(300);
                await Navigation.PushAsync(new Girisekrani());

            }
        }

        /*private void InitializeRouting()
        {
            Routing.RegisterRoute ("Basket", typeof (BasketView));
            Routing.RegisterRoute ("Settings", typeof (SettingsView));
            Routing.RegisterRoute ("OrderDetail", typeof (OrderDetailView));
            Routing.RegisterRoute ("CampaignDetails", typeof(CampaignDetailsView));
            Routing.RegisterRoute ("Checkout", typeof (CheckoutView));
        }*/


    }
}
