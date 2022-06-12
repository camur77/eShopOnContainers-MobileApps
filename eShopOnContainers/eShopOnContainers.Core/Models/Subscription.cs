using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models
{
    public class Subscription
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Subscription()
        {

        }
    }
}
