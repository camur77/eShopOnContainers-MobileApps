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
    public partial class Anasayfa : ContentPage
    {

        VMProducts vmProduct;

        //public ObservableCollection<MyDatabaseRecord> DatabaseItems { get; set; } = new ObservableCollection<MyDatabaseRecord>();

        //public FirebaseClient firebaseClient = new FirebaseClient("https://projeoop-default-rtdb.firebaseio.com/");
        //FirebaseClient firebase = new FirebaseClient("https://projeoop-default-rtdb.firebaseio.com/");

        /* public async Task<List<MyDatabaseRecord>> GetAllPersons()
         {

             return (await firebase
               .Child("Records")
               .OnceAsync<MyDatabaseRecord>()).Select(item => new MyDatabaseRecord
               {
                   Name = item.Object.Name,
                   MyProperty = item.Object.MyProperty
               }).ToList();
         }

         protected async override void OnAppearing()
         {

             base.OnAppearing();
             var allPersons = await GetAllPersons();
             lstPersons.ItemsSource = allPersons;
         }*/



        public class UserInformation
        {
            public ImageSource UserImage { get; set; }

        }
        private ObservableCollection<UserInformation> userCollection;
        public ObservableCollection<UserInformation> UserCollection
        {
            get { return userCollection; }
            set
            {

                userCollection = value;
                OnPropertyChanged();
            }
        }
        public Anasayfa()
        {
            InitializeComponent();
            //vmProduct = new VMProducts();
            this.BindingContext = vmProduct;
            this.BindingContext = this;
            UserCollection = new ObservableCollection<UserInformation>
            {
                new UserInformation{UserImage = "bir.jpeg"},
                new UserInformation{UserImage = "iki.jpeg"},
                new UserInformation{UserImage = "uc.jpeg"},
                new UserInformation{UserImage = "dort.jpeg"},
            };

            /*var collection = firebaseClient
                .Child("Records")
                .AsObservable<MyDatabaseRecord>()
                .Subscribe((dbevent) =>
                {
                    if (dbevent.Object != null)
                    {
                        DatabaseItems.Add(dbevent.Object);
                    }
                });*/
        }

        /*private async void lstProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
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
        }*/





        public List<Product> CollectionsList { get => GetCollections(); }

        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "haporlor2.jpeg", Name = "JBL Go 3 Haporlor", Price = "549,-" });
            trendList.Add(new Product { Image = "logitek2.jpeg", Name = "LOGITEXH Kulaklık", Price = "799,-" });
            trendList.Add(new Product { Image = "scooter2.jpeg", Name = "Kickscooter", Price = "4999,-" });
            trendList.Add(new Product { Image = "watch2.jpeg", Name = "WIKY Watch", Price = "1699,-" });
            return trendList;
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

        public List<Product> minik { get => Getdeneme11(); }

        private List<Product> Getdeneme11()
        {
            var butonresim = new List<Product>();
            butonresim.Add(new Product { Image = "buton1.jpeg" });
            butonresim.Add(new Product { Image = "buton2.jpeg" });
            butonresim.Add(new Product { Image = "buton3.jpeg" });
            butonresim.Add(new Product { Image = "buton4.jpeg" });
            butonresim.Add(new Product { Image = "buton6.jpeg" });
            butonresim.Add(new Product { Image = "buton7.jpeg" });
            butonresim.Add(new Product { Image = "buton8.jpeg" });
            butonresim.Add(new Product { Image = "buton9.jpeg" });
            return butonresim;
        }
    }
    public class deneme11
    {
        public string Image { get; set; }
    }
    public class Banner
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}