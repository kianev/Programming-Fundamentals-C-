using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> dragons =
                new Dictionary<string, Dictionary<string, int[]>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                SaveDragons(command, dragons);
            }

            PrintDragons(dragons);
        }

        private static void PrintDragons(Dictionary<string, Dictionary<string, int[]>> dragons)
        {
            foreach (var type in dragons)
            {
                double averageDamage = type.Value.Select(x => x.Value[0]).Average();
                double averageHealth = type.Value.Select(x => x.Value[1]).Average();
                double averageArmor = type.Value.Select(x => x.Value[2]).Average();

                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, " +
                        $"health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }

        private static void SaveDragons(string command, Dictionary<string, Dictionary<string, int[]>> dragons)
        {
            string[] commands = command
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string type = commands[0];
            string name = commands[1];

            int damage = 45;
            if (commands[2] != "null")
            {
                damage = int.Parse(commands[2]);
            }

            int health = 250;
            if (commands[3] != "null")
            {
                health = int.Parse(commands[3]);
            }

            int armor = 10;
            if (commands[4] != "null")
            {
                armor = int.Parse(commands[4]);
            }

            if (dragons.ContainsKey(type))
            {
                if (dragons[type].ContainsKey(name))
                {
                    dragons[type][name][0] = damage;
                    dragons[type][name][1] = health;
                    dragons[type][name][2] = armor;
                }
                else
                {
                    dragons[type].Add(name, new int[] { damage, health, armor });
                }
            }
            else
            {
                dragons.Add(type, new Dictionary<string, int[]> { { name, new int[] { damage, health, armor } } });
            }
        }
    }
}