using System;

namespace I.Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("-------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to_______________");
            Console.WriteLine("Received by______________");
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}