using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Timers;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.ViewModels.Helpers;
using Firebase.Database;
using Firebase.Database.Query;
using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class beyaz : ContentPage
    {
        VMProducts vmProduct;
        public beyaz()
        {
            vmProduct = new VMProducts();
            this.BindingContext = vmProduct;
            //this.BindingContext = this;
            InitializeComponent();
        }

        private async void lstProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                if (lstProducts.SelectedItem != null)
                {
                    Products product = (Products)e.SelectedItem;
                    if (product != null)
                    {
                        var display = await DisplayActionSheet(product.productName, "Cancel",
                        null, new string[] { "Edit", "Delete" });
                        if (display.Equals("Edit"))
                        {
                            vmProduct.setProduct(product);
                        }
                        else if (display.Equals("Delete"))
                        {
                            vmProduct.setProduct(product);
                            await vmProduct.trnProducts("DELETE");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            lstProducts.SelectedItem = null;
        }
        private async void telefonbir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new beyazbir1());
        }
        private async void telefoniki(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new beyaziki2());
        }
    }
}