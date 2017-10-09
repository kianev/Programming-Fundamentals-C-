using System;
using System.Linq;

namespace _01.RemoveNegativesandRev
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            nums.Sort();

            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}