using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class ProductCreateOptions
    {
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Name { get; set; }
        public ProductCategory? Category { get; set; }
    }
}
