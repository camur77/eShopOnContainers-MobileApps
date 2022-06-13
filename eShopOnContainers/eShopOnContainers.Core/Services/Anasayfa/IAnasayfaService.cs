using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using eShopOnContainers.Core.Models.Anasayfa;

namespace eShopOnContainers.Core.Services.Anasayfa
{
    public interface IAnasayfaService
    {
        Task<ObservableCollection<AnasayfaBrand>> GetCatalogBrandAsync();
        Task<ObservableCollection<AnasayfaItem>> FilterAsync(int catalogBrandId, int catalogTypeId);
        Task<ObservableCollection<AnasayfaType>> GetCatalogTypeAsync();
        Task<ObservableCollection<AnasayfaItem>> GetCatalogAsync();
    }
}
