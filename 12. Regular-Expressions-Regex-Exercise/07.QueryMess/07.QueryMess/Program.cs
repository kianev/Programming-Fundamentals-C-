using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string selectKeyPair = @"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)";
            string replaceSymbol = @"(%20|\+)+";

            string input = Console.ReadLine();

            while (input != "END")
            {
                var words = Regex.Matches(input, selectKeyPair);

                var keyValuePairs = new Dictionary<string, List<string>>();

                for (int i = 0; i < words.Count; i++)
                {
                    var key = words[i].Groups[1].Value;
                    key = Regex.Replace(key, replaceSymbol, w => " ").Trim();

                    var value = words[i].Groups[2].Value;
                    value = Regex.Replace(value, replaceSymbol, w => " ").Trim();

                    if (!keyValuePairs.ContainsKey(key))
                    {
                        keyValuePairs[key] = new List<string>();
                    }

                    keyValuePairs[key].Add(value);
                }

                foreach (var item in keyValuePairs)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}