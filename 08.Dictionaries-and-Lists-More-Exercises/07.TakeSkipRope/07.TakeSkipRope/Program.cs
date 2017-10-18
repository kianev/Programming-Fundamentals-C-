using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TakeSkipRope
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> nonNumbers = new List<string>();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            int skipTotal = 0;

            string result = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    nonNumbers.Add(input[i].ToString());
                }
            }

            for (int i = 0; i < numbers.Count; i += 2)
            {
                takeList.Add(numbers[i]);
                skipList.Add(numbers[i + 1]);
            }

            for (int i = 0; i < skipList.Count; i++)
            {
                var letters = nonNumbers.Skip(skipTotal).Take(takeList[i]).ToArray();
                var lettersToTake = string.Join("", letters);

                result += lettersToTake;

                skipTotal += skipList[i] + takeList[i];
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}