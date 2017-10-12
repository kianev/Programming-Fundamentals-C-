using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchforaNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToTake = 0;
            int deleteIndex = 0;
            int elementToSearch = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                elementsToTake = numbers[0];
                deleteIndex = numbers[1];
                elementToSearch = numbers[2];
            }

            List<int> newElements = new List<int>();

            for (int i = 0; i < elementsToTake; i++)
            {
                newElements.Add(elements[i]);
            }

            List<int> newElementsDeleted = new List<int>();

            for (int i = deleteIndex; i < newElements.Count; i++)
            {
                newElementsDeleted.Add(newElements[i]);
            }

            if (newElementsDeleted.Contains(elementToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}