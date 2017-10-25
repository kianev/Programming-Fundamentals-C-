using System;
using System.Linq;

namespace _05.Magicexchangeablewords
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string first = input[0];
            string second = input[1];

            var arrayOne = first.ToCharArray().Distinct().ToArray();
            var arrayTwo = second.ToCharArray().Distinct().ToArray();

            if (arrayOne.Length == arrayTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}