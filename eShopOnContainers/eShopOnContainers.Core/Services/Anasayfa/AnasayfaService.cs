using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using eShopOnContainers.Core.Models.Anasayfa;
using eShopOnContainers.Core.Services.RequestProvider;
using eShopOnContainers.Core.Extensions;
using System.Collections.Generic;
using eShopOnContainers.Core.Services.FixUri;
using eShopOnContainers.Core.Helpers;

namespace eShopOnContainers.Core.Services.Anasayfa
{
    public class AnasayfaService : IAnasayfaService
    {

        private readonly IRequestProvider _requestProvider;
        private readonly IFixUriService _fixUriService;

        private const string ApiUrlBase = "c/api/v1/catalog";

        public AnasayfaService(IRequestProvider requestProvider, IFixUriService fixUriService)
        {
            _requestProvider = requestProvider;
            _fixUriService = fixUriService;
        }

        public async Task<ObservableCollection<AnasayfaItem>> GetCatalogAsync()
        {
            var uri = UriHelper.CombineUri(GlobalSetting.Instance.GatewayShoppingEndpoint, $"{ApiUrlBase}/items");

            AnasayfaRoot anasayfa = await _requestProvider.GetAsync<AnasayfaRoot>(uri);

            if (anasayfa?.Data != null)
            {
                _fixUriService.FixCatalogItemPictureUri(anasayfa?.Data);
                return anasayfa?.Data.ToObservableCollection();
            }
            else
                return new ObservableCollection<AnasayfaItem>();
        }

        public Task<ObservableCollection<AnasayfaBrand>> GetCatalogBrandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ObservableCollection<AnasayfaItem>> FilterAsync(int catalogBrandId, int catalogTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<ObservableCollection<AnasayfaType>> GetCatalogTypeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
