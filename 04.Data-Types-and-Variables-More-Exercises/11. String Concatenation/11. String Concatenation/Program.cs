using System;

namespace _11.String_Concatenation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddEven = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());

            string result = "";

            switch(oddEven)
            {
                case "even":
                    for (int i = 1; i <= n; i++)
                    {
                        string input = Console.ReadLine();
                        if(i % 2 == 0)
                        {
                            result += input + delimiter;
                        }
                    }
                    break;

                case "odd":
                    for (int i = 1; i <= n; i++)
                    {
                        string input = Console.ReadLine();
                        if (i % 2 != 0)
                        {
                            result += input + delimiter;
                        }
                    }
                    break;
            }

            Console.WriteLine(result.Remove(result.Length - 1));
        }
    }
}