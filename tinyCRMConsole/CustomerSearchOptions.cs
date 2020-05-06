using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
   public class CustomerSearchOptions
    {
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string VatNumber { get; set; }
        public DateTime CreatedFrom { get; set; }
        public DateTime CreatedTo { get; set; }
    }
}
