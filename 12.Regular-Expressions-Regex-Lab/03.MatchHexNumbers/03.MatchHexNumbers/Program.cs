using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";

            var numbers = Console.ReadLine();

            var nums = Regex.Matches(numbers, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}