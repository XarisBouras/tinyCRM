﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get;  set; }
        public string Name { get; set; }
        public string ProductCategory { get; set; }

      //  public List<Order> ListOfOrdersInProduct = new List<Order>();
           
    }
}
