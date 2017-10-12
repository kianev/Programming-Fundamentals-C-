using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SumReversedNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();

            List<string> reversed = new List<string>();

            for (int i = 0; i < elements.Count; i++)
            {
                char[] inputElement = elements[i].ToCharArray();
                Array.Reverse(inputElement);
                string outputElement = new string(inputElement);

                reversed.Add(outputElement);
            }

            int sum = 0;

            foreach (var item in reversed)
            {
                int number = int.Parse(item);
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}