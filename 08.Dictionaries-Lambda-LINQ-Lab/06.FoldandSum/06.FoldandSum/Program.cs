using System;
using System.Linq;

namespace _06.FoldandSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] firstLeft = numbers.Take(k).Reverse().ToArray();
            int[] lastRight = numbers.Skip(k * 3).Take(k).Reverse().ToArray();
            int[] row1 = firstLeft.Concat(lastRight).ToArray();
            int[] row2 = numbers.Skip(k).Take(k * 2).ToArray();

            var result = row1.Select((x, i) => x + row2[i]);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}