using System;
using System.Linq;
using System.IO;

namespace _06.MaxSequenceofEqualEl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            File.Delete("output.txt");

            int bestStart = 0;
            int bestLength = 1;
            int start = 0;
            int len = 1;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[start])
                {
                    len++;
                    if (len > bestLength)
                    {
                        bestLength = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }



            }

            File.WriteAllText("output.txt", "");

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                File.AppendAllText("output.txt", numbers[i].ToString() + " ");
            }
        }
    }
}
