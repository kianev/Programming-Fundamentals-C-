using System;

namespace _04.VariableinHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hex, 16));
        }
    }
}
