using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace eShopOnContainers.Core.Models
{
    public class Products : INotifyPropertyChanged
    {
        private Guid _productId { get; set; }

        public Guid productId
        {
            get { return _productId; }
            set
            {
                _productId = value; OnPropertyChanged();
            }
        }
        private string _productName { get; set; }

        public string productName
        {
            get { return _productName; }
            set
            {
                _productName = value; OnPropertyChanged();
            }
        }
        private double? _productPrice { get; set; }

        public double? productPrice
        {
            get { return _productPrice; }
            set
            {
                _productPrice = value; OnPropertyChanged();
            }
        }

        private string _productImage { get; set; }

        public string productImage
        {
            get { return _productImage; }
            set
            {
                _productImage = value; OnPropertyChanged();
            }
        }

        private string _productBeyaz { get; set; }

        public string productBeyaz
        {
            get { return _productBeyaz; }
            set
            {
                _productBeyaz = value; OnPropertyChanged();
            }
        }

        private string _productBeyazFiyat { get; set; }

        public string productBeyazFiyat
        {
            get { return _productBeyazFiyat; }
            set
            {
                _productBeyazFiyat = value; OnPropertyChanged();
            }
        }

        private string _productBeyazImage { get; set; }

        public string productBeyazImage
        {
            get { return _productBeyazImage; }
            set
            {
                _productBeyazImage = value; OnPropertyChanged();
            }
        }

        private string _productTV { get; set; }

        public string productTV
        {
            get { return _productTV; }
            set
            {
                _productTV = value; OnPropertyChanged();
            }
        }

        private string _productTVFiyat { get; set; }

        public string productTVFiyat
        {
            get { return _productTVFiyat; }
            set
            {
                _productTVFiyat = value; OnPropertyChanged();
            }
        }

        private string _productTVImage { get; set; }

        public string productTVImage
        {
            get { return _productTVImage; }
            set
            {
                _productTVImage = value; OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
