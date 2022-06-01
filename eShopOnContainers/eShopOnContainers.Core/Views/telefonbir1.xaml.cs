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
    public partial class telefonbir1 : ContentPage
    {
        public telefonbir1()
        {
            this.BindingContext = this;
            InitializeComponent();
        }
        public List<Product> TrendsList { get => GetTrends(); }

        private List<Product> GetTrends()
        {
            var colList = new List<Product>();
            colList.Add(new Product { Image = "galaxy1.jpeg", Name = "Galaxy s21 5G", Price = "10499,-" });
            colList.Add(new Product { Image = "galaxy2.jpeg", Name = "Galaxy A32 128 GB", Price = "4999,-" });
            colList.Add(new Product { Image = "galaxy3.jpeg", Name = "Galaxy Note 20 256 GB", Price = "9999,-" });
            colList.Add(new Product { Image = "utu1.jpeg", Name = "PHILIPS Buharlı Ütü", Price = "1699.-" });
            return colList;
        }
    }
    public class Banner1
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }
}