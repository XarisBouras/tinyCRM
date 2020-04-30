using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; private set; }
        public string Name { get; set; }


        public Product()
        {
            var random = new Random();
            var value = Math.Round(random.NextDouble() * 1000, 2);
            Price = (decimal) value;
        }
    }
}
