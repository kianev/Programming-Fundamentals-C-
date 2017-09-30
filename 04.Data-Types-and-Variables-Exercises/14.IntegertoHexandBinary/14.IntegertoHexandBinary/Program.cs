using System;

namespace _14.IntegertoHexandBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string hexValue = input.ToString("X");
            string binary = Convert.ToString(input, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binary);
        }
    }
}
