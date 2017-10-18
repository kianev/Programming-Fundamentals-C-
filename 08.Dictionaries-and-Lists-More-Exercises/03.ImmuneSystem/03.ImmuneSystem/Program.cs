using System;
using System.Collections.Generic;

namespace _03.ImmuneSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var initialHealth = int.Parse(Console.ReadLine());
            var health = initialHealth;
            var virusesList = new List<string>();

            while (health > 0)
            {
                var input = Console.ReadLine();
                var virusStrenght = 0;
                var time = 0;

                if (input == "end") break;

                for (int i = 0; i < input.Length; i++)
                {
                    virusStrenght += input[i];
                }

                if (!virusesList.Contains(input))
                {
                    virusesList.Add(input);
                    
                    virusStrenght = virusStrenght / 3;
                    time = virusStrenght * input.Length;
                }
                else
                {
                    virusStrenght = virusStrenght / 3;
                    time = virusStrenght * input.Length / 3;
                }

                health -= time;
                var minutes = time / 60;
                var seconds = time - minutes * 60;

                Console.WriteLine($"Virus {input}: {virusStrenght} => {time} seconds");
                if (health <= 0) break;
                Console.WriteLine($"{input} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {health}");

                health += health * 20 / 100;
                if (health > initialHealth)
                {
                    health = initialHealth;
                }
            }

            if (health > 0) Console.WriteLine($"Final Health: {health}");
            else Console.WriteLine($"Immune System Defeated.");
        }
    }
}