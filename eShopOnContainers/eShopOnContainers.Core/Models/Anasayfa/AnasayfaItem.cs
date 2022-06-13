using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Anasayfa
{
    public class AnasayfaItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public int CatalogBrandId { get; set; }
        public string CatalogBrand { get; set; }
        public int CatalogTypeId { get; set; }
        public string CatalogType { get; set; }
        public int AnasayfaBrandId { get; internal set; }
        public string AnasayfaBrand { get; internal set; }
        public int AnasayfaTypeId { get; internal set; }
        public string AnasayfaType { get; internal set; }
    }
}
