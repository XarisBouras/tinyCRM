﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
   public class ProductSearchOptions
    {
        public int ProductId { get; set; }
        public decimal PriceFrom { get; set; }
        public decimal PriceTo { get; set; }
        public string Categories { get; set; }
    }
}
