using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int repeat = 1;
            int mostFreqNum = numbers[0];
            int bestLength = 0;

            for (int i = 0; i < numbers.Length ; i++)
            {
                for (int j = 1; j < numbers.Length - i; j++)
                {
                    if (numbers[i] == numbers[i + j])
                    {
                        repeat++;
                    }

                    if (repeat > bestLength)
                    {
                        mostFreqNum = numbers[i];
                        bestLength = repeat;
                    }
                }

                repeat = 1;
            }

            Console.WriteLine(mostFreqNum);
        }
    }
}