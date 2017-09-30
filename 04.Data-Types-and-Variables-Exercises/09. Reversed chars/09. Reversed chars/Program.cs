using System;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
           
            char[] letters = new char[3];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (Console.ReadLine()[0]);
            }

            Array.Reverse(letters);
            Console.WriteLine(string.Join("", letters));
        }
    }
}
