﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
    }
}
