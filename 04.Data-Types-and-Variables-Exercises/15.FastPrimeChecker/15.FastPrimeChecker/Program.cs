using System;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool primeNum = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        primeNum = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {primeNum}");
            }

        }
    }
}
