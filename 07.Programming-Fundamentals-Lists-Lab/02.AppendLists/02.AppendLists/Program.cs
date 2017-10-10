using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] lists = Console.ReadLine().Split('|');

            List<int> result = new List<int>();

            for (int i = lists.Length - 1; i >= 0; i--)
            {
                int[] list = lists[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse).ToArray();

                result.AddRange(list);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}