using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var users = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var ip = input[0];
                var name = input[1];
                int seconds = int.Parse(input[2]);

                if (!users.ContainsKey(name))
                {
                    users[name] = new SortedDictionary<string, int>();
                }

                if (!users[name].ContainsKey(ip))
                {
                    users[name].Add(ip, seconds);
                }
                else
                {
                    users[name][ip] += seconds;
                }
            }

            foreach (var user in users)
            {
                var totalTime = users[user.Key].Values.Sum();
                var ipList = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalTime} [{string.Join(", ", ipList)}]");
            }
        }
    }
}