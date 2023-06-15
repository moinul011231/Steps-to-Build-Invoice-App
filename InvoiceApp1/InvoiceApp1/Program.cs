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
                new { Name = "Cucumber", Price = 20, InStock = 10 },
                new { Name = "Fish", Price = 100, InStock = 15 },
                new { Name = "Papaya", Price = 30, InStock = 5 },
                new { Name = "Kiwifruit", Price = 150, InStock = 7 },
                new { Name = "Watermelon", Price = 200, InStock = 5 },
                new { Name = "Ladyfinger", Price = 50, InStock = 10 },
            };
            foreach (var product in products)
            {
                Console.WriteLine("{0} Price({1})tk Instock({2}Kg)", product.Name, product.Price, product.InStock);
            }
            Console.WriteLine();
            var productNames = new List<string>();
            var quantities = new List<int>();

            Console.WriteLine("Enter the product name: ");
            string productName = Console.ReadLine();

            while (productName != "")
            {
                // Validate the product name
                if (!products.Any(p => p.Name == productName))
                {
                    Console.WriteLine("Invalid product name. Please enter one of the following product names:");
                    foreach (var product in products)
                    {
                        Console.WriteLine(product.Name);
                    }
                }




            }



        }
    }
}