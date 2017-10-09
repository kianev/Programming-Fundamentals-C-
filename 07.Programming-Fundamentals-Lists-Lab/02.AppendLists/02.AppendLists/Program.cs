using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lists = Console.ReadLine()
                .Split('|')
                .ToList();

            List<string> result = new List<string>();

            for (int i = lists.Count - 1; i >= 0; i--)
            {
                var spaceRemoved = new List<string>();
                spaceRemoved = lists[i].Split(' ').ToList();

                foreach (var item in spaceRemoved)
                {
                    if (item != "")
                    {
                        result.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}