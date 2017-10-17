using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddFilter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ').ToArray();

            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            var average = evenNumbers.Average();

            for (int i = 0; i < evenNumbers.Count; i++)
            {
                if (evenNumbers[i] > average)
                {
                    evenNumbers[i] += 1;
                }
                else
                {
                    evenNumbers[i] -= 1;
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}