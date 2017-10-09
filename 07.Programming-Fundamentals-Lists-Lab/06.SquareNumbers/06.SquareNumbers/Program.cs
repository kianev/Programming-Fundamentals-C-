using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesandRev
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<int> squares = new List<int>();

            foreach (var num in nums)
            {
                if (Math.Sqrt(num) % 1 == 0)
                {
                    squares.Add((int)num);
                }
            }

            squares.Sort();
            squares.Reverse();

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}