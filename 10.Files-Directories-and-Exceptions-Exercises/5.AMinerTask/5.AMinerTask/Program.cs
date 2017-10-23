using System;
using System.Collections.Generic;
using System.IO;

namespace _03.AMinerTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            string ore = "";

            var ores = new Dictionary<string, long>();

            while (input != "stop")
            {
                count++;

                if (count % 2 != 0)
                {
                    ore = input;
                    if (!ores.ContainsKey(input))
                    {
                        ores[input] = 0;
                    }
                }

                if (count % 2 == 0)
                {
                    ores[ore] += long.Parse(input);
                }

                input = Console.ReadLine();
            }

            if (input == "stop")
            {
                foreach (var pair in ores)
                    Console.WriteLine("{0} -> {1}",
                      pair.Key, pair.Value);
            }

           
        }
    }
}