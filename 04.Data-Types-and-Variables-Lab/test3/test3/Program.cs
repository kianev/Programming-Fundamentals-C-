using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
               int currentNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNum} -> {special}");
                sum = 0;
                i = currentNum;
            }


        }
    }
}
