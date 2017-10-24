using System;
using System.Collections.Generic;
using System.IO;

namespace _03.AMinerTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String[] input = File.ReadAllLines("input.txt");

            Dictionary<string, long> ores = new Dictionary<string, long>();
            File.Delete("output.txt");

            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[i] == "stop" || input[i + 1] == "stop")
                {
                    break;
                }

                var ore = input[i];
                Console.WriteLine(ore);
                long quantity = long.Parse(input[i + 1]);

                if (!ores.ContainsKey(ore))
                {
                    ores.Add(ore, 0);
                }

                ores[ore] += quantity;
            }

            File.WriteAllText("output.txt", "");

            foreach (var item in ores)
            {
                var line = $"{item.Key} -> {item.Value}" + Environment.NewLine;
                File.AppendAllText("output.txt", line);
            }
        }
    }
}