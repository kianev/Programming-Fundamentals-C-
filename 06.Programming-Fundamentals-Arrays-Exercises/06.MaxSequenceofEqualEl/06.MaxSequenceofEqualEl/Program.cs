using System;
using System.Linq;

namespace _06.MaxSequenceofEqualEl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bestStart = 0;
            int bestLength = 1;
            int start = 0;
            int len = 1;
           

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[start])
                {
                    len++;
                    if(len > bestLength)
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

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}