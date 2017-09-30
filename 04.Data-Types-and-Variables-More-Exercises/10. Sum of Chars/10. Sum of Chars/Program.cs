using System;

namespace _10.Sum_of_Chars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int value = Convert.ToInt32(input);
                sum += value;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}