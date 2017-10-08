using System;
using System.Linq;

namespace _03.FoldandSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;

            int[] leftArray = numbers.Take(k).Reverse().ToArray();
            int[] middArray = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightArray = numbers.Skip(numbers.Length - k).Take(k).Reverse().ToArray();

            int[] result = new int[middArray.Length];

            for (int i = 0; i < k; i++)
            {
                result[i] = middArray[i] + leftArray[i];
                result[i + k] = middArray[i + k] + rightArray[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}