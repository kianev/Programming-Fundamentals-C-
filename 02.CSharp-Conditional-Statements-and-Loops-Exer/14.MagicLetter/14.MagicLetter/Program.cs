using System;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string exept = Console.ReadLine();
            string result = "";

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        result = $"{i}{j}{k}";
                        if (!result.Contains(exept))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }
        }
    }
}
