using System;
using System.Linq;

namespace _03.TextFilter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var badWords = Console.ReadLine().Split(',', ' ')
                .Where(w => w.Length > 0)
                .ToArray();
            var text = Console.ReadLine();

            foreach (var word in badWords)
            {
                var wordLength = word.Length;
                text = text.Replace(word, new String('*', wordLength));
            }

            Console.WriteLine(text);
        }
    }
}