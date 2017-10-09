using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNums
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> result = new List<double>();
            result = numbers;

            for (int i = 0; i < result.Count - 1; i++)
            {
                while (result[i] == result[i + 1])
                {
                    double sum = result[i] + result[i + 1];

                    result[i + 1] = sum;
                    result.RemoveAt(i);
                    i = 0;
                    if(result.Count < 2)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}