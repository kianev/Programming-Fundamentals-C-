using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sorted = numbers.OrderByDescending(x => x).Take(3);

            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}