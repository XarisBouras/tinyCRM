using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyCrmConsole
{
    public interface ICustomerService
    {
        Customer CreateCustomer(CustomerCreateOptions options);

       public IQueryable <Customer> SearchCustomer(CustomerSearchOptions options);

        public bool UpdateCustomer(CustomerUpdateOptions options, int? custId);

        Customer GetCustomerById(int? custId);
    }
}
