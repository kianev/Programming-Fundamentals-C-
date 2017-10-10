using System;
using System.Collections.Generic;

namespace _4.SplitbyWordCasing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var word in words)
            {
                int countWord = word.Length;
                int countUpper = 0;
                int countLower = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        countUpper++;
                    }
                    else if (char.IsLower(word[i]))
                    {
                        countLower++;
                    }
                }

                if (countWord == countLower)
                {
                    lowerCase.Add(word);
                }
                else if (countWord == countUpper)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}