using System;

namespace _09.Make_a_Word
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = "";

            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();
                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}