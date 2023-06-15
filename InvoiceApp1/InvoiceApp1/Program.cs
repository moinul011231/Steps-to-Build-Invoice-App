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
            List<Product> products = new List<Product>
            {
                new Product("Product A", 15),
                new Product("Product B", 15),
                new Product("Product C", 20),
                new Product("Product D", 25),
                new Product("Product E", 30),
                new Product("Product F", 35)
            };

            Console.ReadLine();
        }
    }
}
