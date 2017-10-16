using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var userIPs = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] inputString = input.Split(' ').ToArray();

                string user = inputString[2].Substring(5);
                string ip = inputString[0].Substring(3);
                int counter = 1;

                if (!userIPs.ContainsKey(user))
                {
                    userIPs.Add(user, new Dictionary<string, int>());
                }

                if (!userIPs[user].ContainsKey(ip))
                {
                    userIPs[user].Add(ip, counter);
                }
                else
                {
                    userIPs[user][ip]++;
                }

                input = Console.ReadLine();
            }

            foreach (var user in userIPs)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var ips in user.Value)
                {
                    if (ips.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{ips.Key} => {ips.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ips.Key} => {ips.Value}.");
                    }
                }
            }
        }
    }