using System;
using System.Linq;

namespace _10.PairsbyDifference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            foreach (var num in numbers)
            {
                foreach (var numNext in numbers)
                {
                    if (num - numNext == n)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}