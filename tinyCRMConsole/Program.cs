using System;

namespace tinyCRMConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine(IsValidafm("12345g689"));
            Console.WriteLine(IsValidEmail("   xasa@mm.grdd   "));
            
        }
        public static bool IsValidafm(string afm)
        {
            int number;
            if (string.IsNullOrWhiteSpace(afm))
            {
                return false;
            }

            afm = afm.Trim();

            if (afm.Length != 9 || !int.TryParse(afm, out number))
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
                if (s == 1 && (mail.EndsWith(".gr") || mail.EndsWith(".com"))) return true;
            }
            return false;
        }

    }
}
