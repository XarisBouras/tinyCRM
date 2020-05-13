using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class OrderCreateOptions
    {
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }

        public OrderCreateOptions()
        {
            ProductIds = new List<int>();
            TotalAmount = 0M;
         }
    }
}
