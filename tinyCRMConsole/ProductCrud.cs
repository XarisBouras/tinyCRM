using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinyCRMConsole
{
    public class ProductCrud
    {
        public Product CreateProduct(ProductCreateOptions productCreate)
        {

            var product = new Product()
            {
                Name = productCreate.Name,
                Description = productCreate.Description,
                Price = productCreate.Price,
                ProductCategory = productCreate.ProductCategory
            };

            var tinyCrmDbContext = new TinyCrmDbContext();
            tinyCrmDbContext.Add(product);
            tinyCrmDbContext.SaveChanges();
            return product;
        }

        public Product SearchProduct(ProductSearchOptions productSearch)
        {

            var tinyCrmDbContext = new TinyCrmDbContext();
            var result = tinyCrmDbContext.Set<Product>()
                                          .Where( m => (productSearch.PriceFrom <= m.Price && productSearch.PriceTo >= m.Price))
                                          .Where( m => m.ProductCategory == productSearch.Categories)
                                          .Where( m => productSearch.ProductId == m.ProductId)
                                          .SingleOrDefault();


            if (result == null) throw new Exception();
            return result;
        }
    }
}
