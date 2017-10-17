using System;
using System.Numerics;

namespace _03.BigFactorial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            while (n != 1)
            {
                factorial = factorial * n;
                n = n - 1;
            }

            Console.WriteLine(factorial);
        }
    }
}