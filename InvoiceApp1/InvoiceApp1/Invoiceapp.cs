using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace InvoiceApp1
 {

    internal class Invoiceapp
    {
        public static void PrintWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to TechByte!");
            Console.ResetColor();
        }
        public static void PrintTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"===== {title} =====");
            Console.ResetColor();
        }
    }
 }
