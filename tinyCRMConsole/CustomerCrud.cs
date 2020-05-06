using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinyCRMConsole
{
    public class CustomerCrud
    {

        public Customer CreateCustomer(CustomerCreateOptions customerCreate)
        {

            var customer = new Customer()
            {
                
                Firstname = customerCreate.Firstname,
                Lastname = customerCreate.Lastname,
                Email = customerCreate.Email,
                VatNumber = customerCreate.VatNumber,
                Dob = customerCreate.Dob,
                Created = DateTime.Now,
                IsActive = true,
                TotalGross = 0M
            };

            var tinyCrmDbContext = new TinyCrmDbContext();
            tinyCrmDbContext.Add(customer);
            tinyCrmDbContext.SaveChanges();
            return customer;
        }

        public Customer SearchCustomer(CustomerSearchOptions customerSearch)
        {
         
            var tinyCrmDbContext = new TinyCrmDbContext();
            var result = tinyCrmDbContext.Set<Customer>()
                                            .Where(m => (customerSearch.CreatedFrom <= m.Created && customerSearch.CreatedTo >= m.Created))
                                            .Where(m => m.Lastname == customerSearch.Lastname)
                                            .Where(m => m.Firstname == customerSearch.Firstname)
                                            .Where(m => m.VatNumber == customerSearch.VatNumber)
                                            .Where(m => m.CustomerId == customerSearch.CustomerId)
                                            .SingleOrDefault();

            
            if (result == null) throw new Exception();
            return result;

                                            
        }
    }
}
