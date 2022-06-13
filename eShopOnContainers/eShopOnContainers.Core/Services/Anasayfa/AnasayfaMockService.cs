using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.Anasayfa;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.Anasayfa
{
    public class AnasayfaMockService : IAnasayfaService
    {

        private ObservableCollection<AnasayfaItem> MockCatalog = new ObservableCollection<AnasayfaItem>
        {
            new AnasayfaItem { Id = Common.Common.MockCatalogItemId01, PictureUri = "fake_product_01.png", Name = ".NET Bot Blue Sweatshirt (M)", Price = 19.50M, AnasayfaBrandId = 2, AnasayfaBrand = "Visual Studio", AnasayfaTypeId = 2, AnasayfaType = "T-Shirt" },
            new AnasayfaItem { Id = Common.Common.MockCatalogItemId02, PictureUri = "fake_product_02.png", Name = ".NET Bot Purple Sweatshirt (M)", Price = 19.50M, AnasayfaBrandId = 2, AnasayfaBrand = "Visual Studio", AnasayfaTypeId = 2, AnasayfaType = "T-Shirt" },
            new AnasayfaItem { Id = Common.Common.MockCatalogItemId03, PictureUri = "fake_product_03.png", Name = ".NET Bot Black Sweatshirt (M)", Price = 19.95M, AnasayfaBrandId = 2, AnasayfaBrand = "Visual Studio", AnasayfaTypeId = 2, AnasayfaType = "T-Shirt" },
            new AnasayfaItem { Id = Common.Common.MockCatalogItemId04, PictureUri = "fake_product_04.png", Name = ".NET Black Cupt", Price = 17.00M, AnasayfaBrandId = 2, AnasayfaBrand = "Visual Studio", AnasayfaTypeId = 1, CatalogType = "Mug" },
            new AnasayfaItem { Id = Common.Common.MockCatalogItemId05, PictureUri = "fake_product_05.png", Name = "Azure Black Sweatshirt (M)", Price = 19.50M, AnasayfaBrandId = 1, AnasayfaBrand = "Azure", AnasayfaTypeId = 2, AnasayfaType = "T-Shirt" }
        };

        public Task<ObservableCollection<AnasayfaItem>> FilterAsync(int catalogBrandId, int catalogTypeId)
        {
            throw new NotImplementedException();
        }

        public async Task<ObservableCollection<AnasayfaItem>> GetCatalogAsync()
        {
            await Task.Delay(10);

            return MockCatalog;
        }

        public Task<ObservableCollection<AnasayfaBrand>> GetCatalogBrandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ObservableCollection<AnasayfaType>> GetCatalogTypeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
