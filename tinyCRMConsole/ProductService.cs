using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyCrmConsole
{
    public class ProductService : IProductService
    {
        private TinyCrmDbContext context_;

        public ProductService(TinyCrmDbContext context)
        {
            context_ = context;
        }

        public Product CreateProduct(ProductCreateOptions options)
        {

            if (options == null)
            {
                return null;
            }

            var product = new Product()
            {
                Name = options.Name,
                Description = options.Description,
                Price = options.Price.Value,
                Category = options.Category.Value
            };

            context_.Add(product);

            if (context_.SaveChanges() > 0)
            {
                return product;
            }

            return null;
        }

        public IQueryable <Product> SearchProducts(ProductSearchOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var query = context_
                .Set<Product>()
                .AsQueryable();

            if (options.ProductId != null)
            {
                query = query.Where(prod => prod.ProductId == options.ProductId);
            }

            if (!string.IsNullOrWhiteSpace(options.Description))
            {
                query = query.Where(prod => prod.Description == options.Description);
            }

            if (!string.IsNullOrWhiteSpace(options.Name))
            {
                query = query.Where(prod => prod.Name == options.Name);
            }

            if (options.PriceFrom != null)
            {
                query = query.Where(prod => prod.Price >= options.PriceFrom);
            }

            if (options.PriceTo != null)
            {
                query = query.Where(prod => prod.Price <= options.PriceTo);
            }

            if (options.Category != null)
            {
                query = query.Where(prod => prod.Category == options.Category);
            }

            query = query.Take(500);

            return query;
        }

        public bool UpdateProduct(ProductUpdateOptions options, int? prodId)
        {
            if (options == null || prodId == null)
            {
                return false;
            }

            var product = GetProductById(prodId);

            if (product == null)
            {
                return false;
            }
                
            if (!string.IsNullOrWhiteSpace(options.Description))
            {
                product.Description = options.Description;
            }

            if (!string.IsNullOrWhiteSpace(options.Name))
            {
                product.Name = options.Name;
            }

            if (options.Price != null)
            {
                product.Price = options.Price.Value;
            }

            if (options.Category != null)
            {
                product.Category = options.Category.Value;
            }

            if (context_.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public Product GetProductById(int? prodId)
        {
            if (prodId == null)
            {
                return null;
            }

            var product = context_
                .Set<Product>()
                .Where(prod => prod.ProductId == prodId)
                .SingleOrDefault();

            if (product != null)
            {
                return product;
            }
            return null;
        }
    }
}
