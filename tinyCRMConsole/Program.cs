using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace tinyCRMConsole
{
    class Program
    {
        static int Errors = 0;  //Errors: Empty line, double id
        static void Main(string[] args)
        {

            string path = @"C:\Users\ΧΑΡΗΣ\devel\GitHub\tinyCRMConsole\Product_List.csv";

            var reader = new StreamReader(path);
            
            var i = 0;
            string[] productid = new string[200];  //array for storing products id
            var product = new List<Product>(); //List of Product objects

            while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();  //Read Line from Document

                    if (string.IsNullOrWhiteSpace(line))  //check for empty line
                    {
                        Console.WriteLine("Empty line found.");
                        Errors++;
                        continue;
                    }

                    var newProduct = new Product();

                    var values = line.Split(';');

                    if (IsNotNullOrWhitespaceOrDouble(values[0], productid))
                    {
                        newProduct.ProductId = productid[i] = values[0];  //product id
                        newProduct.Name = values[1];  //product name
                        newProduct.Description = values[2];  //product description
                                                             
                        product.Add(newProduct); //add to list of objects

                        i++;
                    }
                }

            var k = 1;
            foreach (var prod in product)
                {
                    Console.WriteLine($"Product {k} id: {prod.ProductId}");
                    Console.WriteLine($"Product {k} name: {prod.Name}");
                    Console.WriteLine($"Product {k} description: {prod.Description}");
                    Console.WriteLine($"Product {k} price: {prod.Price}");
                    Console.WriteLine();
                    k++;
                }

          //  Product[] pinakas = product.ToArray();  //List of objects to array of objects
                                                      // parsing through pinakas[m].Name;
        }

        public static bool IsNotNullOrWhitespaceOrDouble(string element, string[] array)
        {
            if (string.IsNullOrWhiteSpace(element))
            {
                Console.WriteLine("Product id is missing");
                return true;
            }
            for (var i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    Errors++;
                    Console.WriteLine($"Double product ID found, at Document line {i + Errors + 1}");
                    Console.WriteLine();
                    return false;
                }
            }
            return true;
        }
    }
}
