using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRMConsole
{
  public  class Costumer
    {
        public string CostumerId { get; set; }
        public DateTime Created { get; private set; }
        public string Firstname { get; set; }
        public string Lastname {get; set;}
        public string Email { get; set; }
        public string VatNumber { get; private set; }  //afm
        public string Phone { get; set; }
        public decimal TotalGross { get; private set; } 
        public bool IsActive { get; set; }
        public int Age { get; set; }

        public Costumer(string vatNumber)
        {
            if(!IsValidVatnumber(vatNumber))
            {
                throw new Exception("Invalid Vat Number");
            }

            VatNumber = vatNumber;
            Created = DateTime.Now;
        }

        public bool IsValidVatnumber(string vatNumber)
        {
            return !string.IsNullOrWhiteSpace(vatNumber) && vatNumber.Length == 9;
        }

        public bool IsAdult()
        {
            return Age >= 18 && Age < 100;
        }

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
