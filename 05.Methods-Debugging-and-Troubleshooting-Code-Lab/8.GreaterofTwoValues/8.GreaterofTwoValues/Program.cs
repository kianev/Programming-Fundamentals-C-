using System;

namespace _8.GreaterofTwoValues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                var max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if(type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                var max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if(type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                var max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        private static int GetMax(int first, int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}