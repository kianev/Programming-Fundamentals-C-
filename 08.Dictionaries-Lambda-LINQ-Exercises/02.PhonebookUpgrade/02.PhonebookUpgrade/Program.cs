using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] entries = Console.ReadLine().Split(' ').ToArray();

            var phonebook = new SortedDictionary<string, string>();

            while (entries[0] != "END")
            {
                switch (entries[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(entries[1]))
                        {
                            phonebook[entries[1]] = entries[2];
                        }
                        else
                        {
                            phonebook.Add(entries[1], entries[2]);
                        }
                        break;

                    case "S":
                        if (phonebook.ContainsKey(entries[1]))
                        {
                            Console.WriteLine("{0} -> {1}", entries[1], phonebook[entries[1]]);
                        }
                        else
                        {
                            Console.WriteLine($"Contact {entries[1]} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var entry in phonebook)
                        {
                            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
                        }
                        break;
                }

                entries = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}