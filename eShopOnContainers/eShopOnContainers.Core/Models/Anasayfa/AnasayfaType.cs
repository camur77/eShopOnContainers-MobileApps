using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Anasayfa
{
    public class AnasayfaType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
