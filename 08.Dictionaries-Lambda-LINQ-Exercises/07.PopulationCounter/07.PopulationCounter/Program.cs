using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Dictionary<string, Dictionary<string, long>> countries =
                new Dictionary<string, Dictionary<string, long>>();

            String input = Console.ReadLine();

            while (input != "report")
            {
                string[] parameters = input.Split('|');

                var country = parameters[1];
                var city = parameters[0];
                long population = int.Parse(parameters[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, population);
                }
                else
                {
                    countries[country].Add(city, population);
                }

                input = Console.ReadLine();
            }

            foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}