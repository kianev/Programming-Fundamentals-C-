using System;

namespace _8.SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i * 2 - 1);
                sum += i * 2 - 1;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
