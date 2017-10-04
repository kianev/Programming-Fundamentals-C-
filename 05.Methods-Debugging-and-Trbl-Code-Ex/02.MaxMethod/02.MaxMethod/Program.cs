using System;

namespace _02.MaxMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMax(a, b, c);
        }

        private static void GetMax(int a, int b, int c)
        {
           if(a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if(b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}