using System;
using System.Numerics;

namespace _02.ConvfrombaseNtobase10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();

            int n = int.Parse(input[0]);
            char[] num = input[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            for (int i = 0; i < num.Length; i++)
            {
                int currNum = (int)Char.GetNumericValue(num[i]);
                result += currNum * BigInteger.Pow(n, num.Length - 1 - i);
            }

            Console.WriteLine(result);
        }
    }
}