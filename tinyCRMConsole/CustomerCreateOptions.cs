using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrmConsole
{
    public class CustomerCreateOptions
    {     
        public string Email { get; set; }
        public string VatNumber { get; set; }
        public decimal? TotalGross { get; set; }
        public DateTimeOffset? Dob { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
