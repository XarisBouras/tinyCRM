using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
  public  class Customer 
    {
       
        public int CustomerId { get; set; }
        public DateTime Created { get;  set; }
        public string Firstname { get; set; }
        public string Lastname {get; set;}
        public string Email { get; set; }
        public string VatNumber { get;  set; }  //afm
        public DateTime Dob { get; set; }
        public decimal TotalGross { get;  set; } 
        public bool IsActive { get; set; }
       

        //public List<Order> CustomerOrderList = new List<Order>();

       
        //public Customer(string vatNumber, string firstname)
        //{
        //    //if (!IsValidVatnumber(vatNumber))
        //    //{
        //    //    throw new Exception ("Invalid Vat Number");
        //    //}

        //    VatNumber = vatNumber;
        //    Created = DateTime.Now;
        //    Firstname = firstname;
        //}

        //public bool IsValidVatnumber(string vatNumber)
        //{
        //    return !string.IsNullOrWhiteSpace(vatNumber) && vatNumber.Length == 9;
        //}

   

        //public bool IsValidEmail(string mail)
        //{
        //    var s = 0;
        //    if (!string.IsNullOrWhiteSpace(mail))
        //    {
        //        mail = mail.Trim();
        //        for (int i = 0; i < mail.Length; i++)
        //        {
        //            if (mail[i] == '@') s++;
        //        }
        //        if (s == 1 && (mail.EndsWith(".gr") || mail.EndsWith(".com"))) return true;
        //    }
        //    return false;
        //}

    }
}
