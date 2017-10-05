using System;
using System.Numerics;

namespace _13.Factorial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            int zeros = CountZeros(factorial);

            Console.WriteLine(zeros);
        }

        private static int CountZeros(BigInteger factorial)
        {
            int counter = 0;
            while (factorial % 10 == 0)
            {
                counter++;
                factorial /= 10;
            }

            return counter;
        }
    }
}