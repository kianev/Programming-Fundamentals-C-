using System;

namespace _05.FibonacciNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            uint nthFib = Fib(n);
            Console.WriteLine(nthFib);
        }

        private static uint Fib(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            uint a = 0;
            uint b = 1;
            uint c = 1;

            for (uint i = 0; i < n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }

            return c;

        }
    }
}