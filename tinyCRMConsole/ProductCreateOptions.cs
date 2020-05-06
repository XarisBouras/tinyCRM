using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
   public class ProductCreateOptions
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string ProductCategory { get; set; }
    }
}
