using System;
using System.Collections.Generic;

namespace InvoiceApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoiceapp.PrintTitle("TechByte");
            Invoiceapp.PrintWelcomeMessage();
            Console.ReadLine();


            //2nd 
            Invoiceapp.PrintTitle("Available Products");
            var products = new[]
           {
                new { Name = "Product 1", Price = 15 },
                new { Name = "Product 2", Price = 15 },
                new { Name = "Product 3", Price = 20 },
                new { Name = "Product 4", Price = 25 },
                new { Name = "Product 5", Price = 30 },
                new { Name = "Product 6", Price = 35 },
            };

            foreach (var product in products)
            {
                Console.WriteLine("{0} ({1})", product.Name, product.Price);
            }
            Console.WriteLine();
            var productNames = new List<string>();
            var quantities = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter the product name: ");
                var productName = Console.ReadLine();
            }
        }

    }   
}
