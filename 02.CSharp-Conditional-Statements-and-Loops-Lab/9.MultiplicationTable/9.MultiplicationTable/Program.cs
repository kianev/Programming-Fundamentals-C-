using System;

namespace _9.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
            }
        }
    }
}
