using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyCrmConsole
{
    public class CustomerService : ICustomerService
    {
        private TinyCrmDbContext context_;

        public CustomerService(TinyCrmDbContext context)
        {
            context_ = context;
        }

        public Customer CreateCustomer(CustomerCreateOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var customer = new Customer()
            {
                
                Email = options.Email,
                FirstName = options.FirstName,
                LastName = options.LastName,
                VatNumber = options.VatNumber,
                IsActive = true,
                TotalGross = 0M,
                Dob = options.Dob.Value
            };

            context_.Add(customer);

            if (context_.SaveChanges() > 0)
            {
                return customer;
            }

            return null;
        }

        public IQueryable<Customer> SearchCustomer(CustomerSearchOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var query = context_
                .Set<Customer>()
                .AsQueryable();

            if (options.CustomerId != null)
            {
                query = query.Where(cust => cust.CustomerId == options.CustomerId);
            }

            if (!string.IsNullOrWhiteSpace(options.FirstName))
            {
                query = query.Where(cust => cust.FirstName == options.FirstName);
            }

            if (!string.IsNullOrWhiteSpace(options.LastName))
            {
                query = query.Where(cust => cust.LastName == options.LastName);
            }

            if (!string.IsNullOrWhiteSpace(options.VatNumber))
            {
                query = query.Where(cust => cust.VatNumber == options.VatNumber);
            }

            if(options.CreatedFrom != null)
            {
                query = query.Where(cust => cust.Created >= options.CreatedFrom);
            }

            if (options.CreatedTo != null)
            {
                query = query.Where(cust => cust.Created <= options.CreatedTo);
            }

            query = query.Take(500);

            return query;
        }
        public Customer GetCustomerById(int? custId)
        {
            if (custId == null)
            {
                return null;
            }

            var customer = context_
                .Set<Customer>()
                .Where(cust => cust.CustomerId == custId)
                .SingleOrDefault();

            if (customer != null)
            {
                return customer;
            }
            return null;
        }

        public bool UpdateCustomer(CustomerUpdateOptions options, int? custId)
        {
            if (options == null || custId == null)
            {
                return false;
            }

            var customer = GetCustomerById(custId);

            if (customer == null)
            {
                return false;
            }
          
            if (!string.IsNullOrWhiteSpace(options.FirstName))
            {
                customer.FirstName = options.FirstName;
            }

            if (!string.IsNullOrWhiteSpace(options.LastName))
            {
                customer.LastName = options.LastName;
            }

            if (!string.IsNullOrWhiteSpace(options.Email))
            {
                customer.Email = options.Email;
            }

            if(options.IsActive != null)
            {
                customer.IsActive = options.IsActive.Value;
            }

            if (context_.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
