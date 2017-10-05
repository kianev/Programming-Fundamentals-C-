using System;
using System.Collections.Generic;

namespace _07.PrimesinGivenRange
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            string resultArray = String.Join(", ", FindPrimesInRange(startNum, endNum).ToArray());

            if (resultArray.Length > 0)
            {
                Console.WriteLine(resultArray);
            }
            else
            {
                Console.WriteLine("empty list");
            }
          
        }

        private static List<int> FindPrimesInRange(int start, int end)
        {
            var result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;

                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Add(i);
                }
            }

            return result;

        }
    }
}