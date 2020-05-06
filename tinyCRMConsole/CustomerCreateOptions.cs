using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace tinyCRMConsole
{
   public class CustomerCreateOptions
    {
        
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string VatNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
    }
}
