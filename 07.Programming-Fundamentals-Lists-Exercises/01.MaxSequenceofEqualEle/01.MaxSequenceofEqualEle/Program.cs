using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceofEqualEle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 0; i < elements.Count - 1; i++)
            {
                if (elements[i] == elements[i + 1])
                {
                    length++;

                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    length = 1;
                    start = i + 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }
    }
}