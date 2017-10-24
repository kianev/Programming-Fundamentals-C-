using System;
using System.IO;

namespace _02.AdvertisementMessage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] phrases = "Excellent product|Such a great product|I always use that product|Best product of its category"
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] events = "Now I feel good.|I have succeeded to change.|That makes miracles.|I cannot believe but now I feel awesome.|Try it yourself, I am very satisfied."
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Misha"
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] cities = "Burgas, Sofia, Plovdiv, Varna, Ruse"
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            File.Delete("output.txt");

            Random random = new Random();

            string input = File.ReadAllText("input.txt");
            int num = int.Parse(input);

            File.WriteAllText("output.txt", "");

            for (int i = 0; i < num; i++)
            {
                string phrase = phrases[random.Next(phrases.Length)];
                string even = events[random.Next(events.Length)];
                string author = authors[random.Next(authors.Length)];
                string city = cities[random.Next(cities.Length)];

                string output = phrase + ". " + even + " " + author + " - " + city + Environment.NewLine;

                File.AppendAllText("output.txt", output);
            }
        }
    }
}