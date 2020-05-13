using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class CustomerSearchOptions
    {
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VatNumber { get; set; }
        public DateTimeOffset? CreatedFrom { get; set; }
        public DateTimeOffset? CreatedTo { get; set; }
       
    }
}
