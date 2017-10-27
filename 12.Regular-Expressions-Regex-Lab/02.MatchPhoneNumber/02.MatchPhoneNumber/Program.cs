using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pattern = @"((^|\s)\+[359]+\s2\s\d{3}\s\d{4})|(^|\s*?)\+[359]+-2-\d{3}-\d{4}\b";
            
            var phones = Console.ReadLine();

            var matches = Regex.Matches(phones, pattern)
                .Cast<Match>()
                .Select(a => a.Value.Trim()).
                ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}