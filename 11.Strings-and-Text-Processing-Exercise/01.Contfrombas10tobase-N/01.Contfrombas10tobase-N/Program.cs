using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.Contfrombas10tobase_N
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<BigInteger> numbers = new List<BigInteger>();

            numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();

            int n = (int)numbers[0];
            BigInteger base10Num = numbers[1];
            BigInteger reminder;

            string result = null;

            if (n >= 2 && n <= 10)
            {
                while (base10Num > 0)
                {
                    reminder = base10Num % n;
                    base10Num /= n;

                    result = reminder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}