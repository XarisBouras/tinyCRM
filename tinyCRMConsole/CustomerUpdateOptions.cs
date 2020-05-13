using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class CustomerUpdateOptions
    {
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string Email { get; set; }
        public string VatNumber { get; set; }
        public string Phone { get; set; }
        public List<Order> OrderList { get; set; }
        

        public CustomerUpdateOptions()
        {
            OrderList = new List<Order>();
        }
    }
}
