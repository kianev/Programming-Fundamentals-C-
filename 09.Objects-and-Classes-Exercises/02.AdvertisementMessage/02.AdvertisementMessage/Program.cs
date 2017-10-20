using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = "Excellent product|Such a great product|I always use that product|Best product of its category"
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] events = "Now I feel good.|I have succeeded to change.|That makes miracles.|I cannot believe but now I feel awesome.|Try it yourself, I am very satisfied."
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Misha"
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] cities = "Burgas, Sofia, Plovdiv, Varna, Ruse"
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. {1} {2} - {3}",
                    phrases[random.Next(phrases.Length)],
                     events[random.Next(events.Length)],
                      authors[random.Next(authors.Length)],
                       cities[random.Next(cities.Length)]);
            }
        }
    }
}
