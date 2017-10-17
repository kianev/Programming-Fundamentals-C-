using System;
using System.Linq;

namespace _01.SortTimes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var inputOrdered = input.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", inputOrdered));
        }
    }
}