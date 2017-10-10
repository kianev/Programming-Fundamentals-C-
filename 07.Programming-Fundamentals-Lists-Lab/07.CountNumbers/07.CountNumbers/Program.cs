using System;
using System.Linq;

namespace _07.CountNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();

            int count = 1;

            for (int i = 1; i < numbers.Count + 1; i++)
            {
                if (i == numbers.Count)
                    Console.WriteLine(string.Join(" -> ", numbers[i - 1], count));
                else if (numbers[i] == numbers[i - 1]) count++;
                else
                {
                    Console.WriteLine(string.Join(" -> ", numbers[i - 1], count));
                    count = 1;
                }
            }
        }
    }
}