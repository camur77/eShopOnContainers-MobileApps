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
    public partial class Girisekrani : ContentPage
    {
        public Girisekrani()
        {
            InitializeComponent();
        }
        void RegisterLabel_Tapped(object sender, EventArgs args)
        {
            registerStackLayout.IsVisible = true;
            loginStackLayout.IsVisible = false;
        }
        void LoginLabel_Tapped(object sender, EventArgs args)
        {
            registerStackLayout.IsVisible = false;
            loginStackLayout.IsVisible = true;
        }
    }
}