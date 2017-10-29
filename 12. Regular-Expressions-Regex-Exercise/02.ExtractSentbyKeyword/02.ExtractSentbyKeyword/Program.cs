using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.ExtractSentbyKeyword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                string[] words = Regex.Split(sentence, "[^A-Za-z]");
                if (words.Contains(word))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}