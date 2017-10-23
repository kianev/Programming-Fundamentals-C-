using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');

            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            File.WriteAllText("result.txt", "");
            foreach (var wordAndCount in wordCount.OrderByDescending(w => w.Value))
            {
                if (words.Contains(wordAndCount.Key))
                {
                    File.AppendAllText("result.txt",
                        wordAndCount.Key + " -> " + wordAndCount.Value + Environment.NewLine);
                }
            };
        }
    }
}