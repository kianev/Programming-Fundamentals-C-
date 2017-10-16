using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var items = new Dictionary<string, long>();
            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);
            int count = 1;

            while (count <= 10)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
                var obtainedItem = "";

                for (int i = 1; i < input.Length; i += 2)
                {
                    int materialValue = int.Parse(input[i - 1]);
                    string material = input[i];

                    if (!items.ContainsKey(material))
                    {
                        items.Add(material, 0);
                    }

                    items[material] += materialValue;

                    obtainedItem = CheckForObtained(items);
                    if (obtainedItem != "")
                    {
                        Console.WriteLine($"{obtainedItem} obtained!");
                        break;
                    }
                }

                if (obtainedItem != "")
                {
                    break;
                }

                count++;
            }

            PrintItems(items);
        }

        private static void PrintItems(Dictionary<string, long> items)
        {
            var rearItems = items.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToArray();
            var junkItems = items.Skip(3).OrderBy(x => x.Key).ToArray();

            foreach (var rearItem in rearItems)
            {
                Console.WriteLine($"{rearItem.Key}: {rearItem.Value}");
            }
            foreach (var junkItem in junkItems)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }

        private static string CheckForObtained(Dictionary<string, long> items)
        {
            string itemForCraft = "";

            if (items["shards"] >= 250)
            {
                itemForCraft = "Shadowmourne";
                items["shards"] -= 250;
            }

            if (items["fragments"] >= 250)
            {
                itemForCraft = "Valanyr";
                items["fragments"] -= 250;
            }

            if (items["motes"] >= 250)
            {
                itemForCraft = "Dragonwrath";
                items["motes"] -= 250;
            }

            return itemForCraft;
        }
    }
}