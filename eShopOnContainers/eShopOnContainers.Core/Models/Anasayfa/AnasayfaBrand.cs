using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Anasayfa
{
    public class AnasayfaBrand
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return Brand;
        }
    }
}
