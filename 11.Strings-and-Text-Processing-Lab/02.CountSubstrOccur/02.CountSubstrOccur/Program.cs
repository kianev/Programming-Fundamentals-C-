using System;

namespace _01.ReverseString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 0;
            int index = -1;
            while (true)
            {
                index = text.IndexOf(pattern, index + 1);
                if (index == -1)
                {
                    break;
                }
                count++;
            }

            Console.WriteLine(count);
        }
    }
}