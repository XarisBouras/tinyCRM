using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class Order
    {
        public int OrderId { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTimeOffset Created { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        public Order()
        {
            OrderProducts = new List<OrderProduct>();
            Created = DateTimeOffset.Now;
        }
    }
}
