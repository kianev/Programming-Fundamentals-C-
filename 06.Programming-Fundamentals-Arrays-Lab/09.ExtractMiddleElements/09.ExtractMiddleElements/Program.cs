using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("{ " + string.Join(", ", numbers) + " }");
            }
            else if (numbers.Length % 2 == 0)
            {
                int[] middleElements = new int[2];

                for (int i = numbers.Length / 2 - 1; i < numbers.Length / 2 + 1; i++)
                {
                    middleElements[i - (numbers.Length / 2 - 1)] = numbers[i];
                }

                Console.WriteLine("{ " + string.Join(", ", middleElements) + " }");
            }
            else
            {
                int[] middleElements = new int[3];

                for (int i = numbers.Length / 2 - 1; i < numbers.Length / 2 + 2; i++)
                {
                    middleElements[i - (numbers.Length / 2 - 1)] = numbers[i];
                }

                Console.WriteLine("{ " + string.Join(", ", middleElements) + " }");
            }
        }
    }
}