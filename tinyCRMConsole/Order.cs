using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
    class Order
    {
        public string OrderId { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; private set; }
    }
}
