using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Anasayfa
{
    public class AnasayfaRoot
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public List<AnasayfaItem> Data { get; set; }
    }
}
