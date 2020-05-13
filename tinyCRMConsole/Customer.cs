using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
   public class Customer
    {
        public int CustomerId { get; set; }  
        public string Email { get; set; }
        public string VatNumber { get; set; }
        public decimal TotalGross { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Dob { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public List<Order> OrderList { get; set; }

        public Customer()
        {
            OrderList = new List<Order>();
            Created = DateTimeOffset.Now;
        }
    }
}
