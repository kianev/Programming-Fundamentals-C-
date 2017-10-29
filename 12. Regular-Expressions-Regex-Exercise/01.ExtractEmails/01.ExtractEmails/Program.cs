using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";

            var emailMatches = Regex.Matches(input, pattern);

            foreach (Match email in emailMatches)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}