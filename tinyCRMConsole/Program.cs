using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;

namespace tinyCRMConsole
{
    class Program
    {
        static int Errors = 0;  //Errors: Empty line, double id
        static void Main(string[] args)
        {

            string path = @"C:\Users\ΧΑΡΗΣ\devel\GitHub\tinyCRMConsole\Product_Test.csv";

            using (var reader = new StreamReader(path))
            {
                var i = 0;
                string[,] product = new string[200, 3]; // twodimensional array 200x3 (id, name, description)
                double[] price = new double[200];  //Random prices of products

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();  //Read Line from Document

                    if (string.IsNullOrWhiteSpace(line))  //check for empty line
                    {
                        Console.WriteLine("Empty line found.");
                        Errors++;
                        continue;
                    }

                    var values = line.Split(';');

                    if (IsNotNullOrWhitespaceOrDouble(values[0], product))
                    {
                        product[i, 0] = values[0];  //product id
                        product[i, 1] = values[1];  //product name
                        product[i, 2] = values[2];  //product description
                        price[i] = CreatePrice();   //product price
                        i++;
                    }

                }

                for (var j = 0; j < i; j++)
                {
                    Console.WriteLine($"Product {j + 1} id: {product[j, 0]}");
                    Console.WriteLine($"Product {j + 1} name: {product[j, 1]}");
                    Console.WriteLine($"Product {j + 1} description: {product[j, 2]}");
                    Console.WriteLine($"Product {j + 1} price: {price[j]}");
                    Console.WriteLine();
                }
            }

        }

        public static double CreatePrice()
        {
            Random random = new Random();
            var value = random.NextDouble() * 1000;
            return value;
        }

        public static bool IsNotNullOrWhitespaceOrDouble(string element, string[,] array)
        {
            if (string.IsNullOrWhiteSpace(element))
            {
                Console.WriteLine("Product id is missing");
                return true;
            }
            for (var i = 0; i < array.GetLength(0); i++)
            {
                if (element == array[i, 0])
                {
                    Errors++;
                    Console.WriteLine($"Double product ID found, at Document line {i + Errors +1}");
                    Console.WriteLine();
                    return false;
                }
            }
            return true;
        }


        //public static bool IsValidafm(string afm)
        //{
        //    int number;
        //    if (string.IsNullOrWhiteSpace(afm))
        //    {
        //        return false;
        //    }

        //    afm = afm.Trim();

        //    if (afm.Length != 9 || !int.TryParse(afm, out number))
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //public static bool IsAdult(int age)
        //{
        //    return age >= 18 && age <= 100;
        //}

        //public static bool IsValidEmail(string mail)
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
