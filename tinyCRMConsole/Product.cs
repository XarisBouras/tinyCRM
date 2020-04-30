using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        public double Price { get; private set; }
        public string Name { get; set; }


        public Product()
        {
            Random random = new Random();
            var value = random.NextDouble() * 1000;
            Price = value;
        }
    }
}
