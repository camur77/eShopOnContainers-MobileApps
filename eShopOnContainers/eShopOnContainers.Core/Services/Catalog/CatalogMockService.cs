using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.Catalog;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.Catalog
{
    public class CatalogMockService : ICatalogService
    {
        private ObservableCollection<CatalogBrand> MockCatalogBrand = new ObservableCollection<CatalogBrand>
        {
            new CatalogBrand { Id = 1, Brand = "Azure" },
            new CatalogBrand { Id = 2, Brand = "Visual Studio" }
        };

        private ObservableCollection<CatalogType> MockCatalogType = new ObservableCollection<CatalogType>
        {
            new CatalogType { Id = 1, Type = "Mug" },
            new CatalogType { Id = 2, Type = "T-Shirt" }
        };

        private ObservableCollection<CatalogItem> MockCatalog = new ObservableCollection<CatalogItem>
        {
            new CatalogItem { Id = Common.Common.MockCatalogItemId01, PictureUri = "asus11.png", Name = "Asus Windows 11 Laptop", Price = 19.50M, CatalogBrandId = 2, CatalogBrand = "Visual Studio", CatalogTypeId = 2, CatalogType = "T-Shirt" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId02, PictureUri = "hpceleron.png", Name = "HP CELERON Windows 11 Gri Laptop", Price = 19.50M, CatalogBrandId = 2, CatalogBrand = "Visual Studio", CatalogTypeId = 2, CatalogType = "T-Shirt" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId03, PictureUri = "hppavilion.png", Name = "HP Pavilion Windows11 Blue Laptop", Price = 19.95M, CatalogBrandId = 2, CatalogBrand = "Visual Studio", CatalogTypeId = 2, CatalogType = "T-Shirt" },
            
            
        };

        public async Task<ObservableCollection<CatalogItem>> GetCatalogAsync()
        {
            await Task.Delay(10);

            return MockCatalog;
        }

        public async Task<ObservableCollection<CatalogItem>> FilterAsync(int catalogBrandId, int catalogTypeId)
        {
            await Task.Delay(10);

            return MockCatalog
                .Where(c => c.CatalogBrandId == catalogBrandId &&
                c.CatalogTypeId == catalogTypeId)
                .ToObservableCollection();
        }

        public async Task<ObservableCollection<CatalogBrand>> GetCatalogBrandAsync()
        {
            await Task.Delay(10);

            return MockCatalogBrand;
        }

        public async Task<ObservableCollection<CatalogType>> GetCatalogTypeAsync()
        {
            await Task.Delay(10);

            return MockCatalogType;
        }
    }
}