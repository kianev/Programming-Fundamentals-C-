using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split("\\ /()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x.Trim())
                 .ToArray();

            List<string> validUsernames = new List<string>();

            var pattern = @"^[a-zA-Z][a-zA-Z\d_]{2,24}$";

            foreach (var item in input)
            {
                if (Regex.Match(item, pattern).Success)
                {
                    validUsernames.Add(item);
                }
            }

            int maxLenght = 0;
            int bestIndex = 0;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                int currUsernameLenght = validUsernames[i].Length;
                int nextUsernameLength = validUsernames[i + 1].Length;

                if (maxLenght < currUsernameLenght + nextUsernameLength)
                {
                    maxLenght = currUsernameLenght + nextUsernameLength;
                    bestIndex = i;
                }
            }

            Console.WriteLine(validUsernames[bestIndex]);
            Console.WriteLine(validUsernames[bestIndex + 1]);
        }
    }
}