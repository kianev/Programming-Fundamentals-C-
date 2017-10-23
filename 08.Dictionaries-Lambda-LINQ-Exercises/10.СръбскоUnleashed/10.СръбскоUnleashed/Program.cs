using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.СръбскоUnleashed
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var concerts = new Dictionary<string, Dictionary<string, long>>();

            while (line != "End")
            {
                var elements = line.Split('@');

                if (elements.Length != 2)
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (!elements[0].EndsWith(" "))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var rightSide = elements[1].Split(' ');
                if (rightSide.Length < 3)
                {
                    line = Console.ReadLine();
                    continue;
                }

                long ticketPrice;
                long ticketCount;

                if (!long.TryParse(rightSide[rightSide.Length - 2], out ticketPrice))
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (!long.TryParse(rightSide[rightSide.Length - 1], out ticketCount))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var singer = elements[0].Trim();
                long totalPrice = ticketCount * ticketPrice;
                var venue = "";
                for (int i = 0; i < rightSide.Length - 2; i++)
                {
                    venue += rightSide[i] + " ";
                }

                if (!concerts.ContainsKey(venue))
                {
                    concerts[venue] = new Dictionary<string, long>();
                }

                if (!concerts[venue].ContainsKey(singer))
                {
                    concerts[venue][singer] = 0;
                }

                concerts[venue][singer] += totalPrice;

                line = Console.ReadLine();
            }

            foreach (var venueAndSinger in concerts)
            {
                string venue = venueAndSinger.Key;

                Dictionary<string, long> singers = venueAndSinger.Value;

                Console.WriteLine(venue);

                foreach (var singerAndPrice in singers.OrderByDescending(s => s.Value))
                {
                    string singer = singerAndPrice.Key;
                    long totalPrice = singerAndPrice.Value;

                    Console.WriteLine($"#  {singer} -> {totalPrice}");
                }
            }
        }
    }
}