using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class OrderUpdateOptions
    {
        public int? OrderId { get; set; }
        public List<int> ProductIds { get; set; }
        public string DeliveryAddress { get; set; }

        public OrderUpdateOptions()
        {
            ProductIds = new List<int>();
        }
    }
}
