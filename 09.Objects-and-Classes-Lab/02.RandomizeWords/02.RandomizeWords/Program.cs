using System;
using System.Linq;

namespace _02.RandomizeWords
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            string[] text = new string[input.Length];

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[rnd.Next(0, input.Length)]);
            }
        }
    }
}