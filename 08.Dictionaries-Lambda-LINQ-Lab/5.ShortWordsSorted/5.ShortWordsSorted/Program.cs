using System;
using System.Linq;

namespace _5.ShortWordsSorted
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sentence = Console.ReadLine().ToLower();

            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };

            string[] words = sentence.Split(separators);

            var results = words
                .Where(w => w != "")
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct();

            Console.WriteLine(string.Join(", ", results));
        }
    }
}