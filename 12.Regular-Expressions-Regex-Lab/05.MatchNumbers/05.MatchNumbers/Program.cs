using System;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var input = Console.ReadLine();

            var numbers = Regex.Matches(input, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}