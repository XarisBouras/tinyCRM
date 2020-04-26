using System;

namespace tinyCRMConsole
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("Give your afm.");
              Console.WriteLine(IsValidafm("88777"));
            //   Console.WriteLine(IsValidafm("098765432"));
            //  Console.WriteLine(IsValidafm("    0123547853  "));
            //  Console.WriteLine(IsValidafm(null));
            // var val = IsAdult(23);
            // Console.WriteLine(val);
            // Console.WriteLine(IsValidEmail("xaxa@cdcd.gr"));
            var array = new int[4];
            for(int i=0; i<array.Length; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    array[i] = num;
                 
                }
                else Console.WriteLine("Fail");
            }
            foreach(var i in array)
            {
                Console.WriteLine("Hey" + i);
            }
           
        }
        public static bool IsValidafm(string afm)
        {
            int number;
            if (string.IsNullOrWhiteSpace(afm))
            {
                return false;
            }

            afm = afm.Trim();

            if (afm.Length != 9)
            {
                return false;
            }

            if (!int.TryParse(afm, out number))
            {
                return false;
            }

            return true;
        }

        public static bool IsAdult(int age)
        {
            return age >= 18 && age <= 100;
        }

        public static bool IsValidEmail(string mail)
        {
            var s = 0;
            if (!string.IsNullOrWhiteSpace(mail))
            {
                mail = mail.Trim();
                for (int i = 0; i < mail.Length; i++)
                {
                    if (mail[i] == '@') s++;
                }
                if (s == 1 && (mail.Contains(".gr") || mail.Contains(".com"))) return true;
            }
            return false;
        }

    }
}
