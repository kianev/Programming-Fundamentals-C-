using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string startEndKeys = Console.ReadLine();

            var pattern = @"^(?<startKey>[a-zA-z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]+)";

            string text = Console.ReadLine();

            var keys = Regex.Match(startEndKeys, pattern);

            if (keys.Success)
            {
                string startkey = keys.Groups[1].Value;
                string endKey = keys.Groups[2].Value;

                var keyPattern = $@"{startkey}(?<word>.*?){endKey}";
                var wordMatches = Regex.Matches(text, keyPattern);

                var result = new StringBuilder();

                foreach (Match wordMatch in wordMatches)
                {
                    result.Append(wordMatch.Groups["word"].Value);
                }

                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}