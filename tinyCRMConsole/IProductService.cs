using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyCrmConsole
{
    public interface IProductService
    {
        Product CreateProduct(ProductCreateOptions options);

        IQueryable <Product> SearchProducts(ProductSearchOptions options);

        bool UpdateProduct(ProductUpdateOptions options, int? prodId);

        Product GetProductById(int? prodId);
    }
}
