using System;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int number = num;
                int sum = 0;

                while (num > 0)
                {
                    int digit = number % 10;
                    sum += digit;
                    number /= 10;
                }

                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{number} -> {special}");
               
            }

        }
    }
}
