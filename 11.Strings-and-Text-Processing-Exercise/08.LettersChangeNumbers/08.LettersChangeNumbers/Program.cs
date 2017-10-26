using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' ', '\t'},
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char first = Convert.ToChar(input[i].Substring(0, 1));
                double num = double.Parse(input[i].Substring(1, input[i].Length - 2));
                char last = Convert.ToChar(input[i].Substring(input[i].Length - 1, 1));

                if (char.IsUpper(first))
                {
                    var firstPosition = first - 'A' + 1;
                    sum += num / firstPosition;
                }
                else
                {
                    var firstPosition = first - 'a' + 1;
                    sum += num * firstPosition;
                }

                if (char.IsUpper(last))
                {
                    var lastPosition = last - 'A' + 1;
                    sum -= lastPosition;
                }
                else
                {
                    var lastPosition = last - 'a' + 1;
                    sum += lastPosition;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}