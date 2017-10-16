using System;
using System.Collections.Generic;

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

            //2nd Solution
            //Dictionary<string, long> ores = new Dictionary<string, long>();

            //for (int i = 1; ; i++)
            //{
            //    string ore = Console.ReadLine();

            //    if (ore == "stop")
            //    {
            //        break;
            //    }

            //    long quantity = long.Parse(Console.ReadLine());

            //    if (!ores.ContainsKey(ore))
            //    {
            //        ores.Add(ore, 0);
            //    }

            //    ores[ore] += quantity;
            //}

            //foreach (var item in ores)
            //{
            //    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            //}
        }
    }
}