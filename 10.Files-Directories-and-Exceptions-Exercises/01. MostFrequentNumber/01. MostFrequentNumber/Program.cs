using System;
using System.Linq;
using System.IO;

namespace _08.MostFrequentNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           
            int[] numbers = File.ReadAllText("input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            File.Delete("output.txt");

            int repeat = 1;
            int mostFreqNum = numbers[0];
            int bestLength = 0;

            for (int i = 0; i < numbers.Length; i++)
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

            File.WriteAllText("output.txt", mostFreqNum.ToString());
        }
    }
}