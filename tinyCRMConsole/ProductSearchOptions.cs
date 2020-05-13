using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class ProductSearchOptions
    {
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        public ProductCategory? Category { get; set; }
    }
}
