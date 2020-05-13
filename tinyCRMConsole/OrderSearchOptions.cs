using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class OrderSearchOptions
    {
        public int? OrderId { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
    }
}
