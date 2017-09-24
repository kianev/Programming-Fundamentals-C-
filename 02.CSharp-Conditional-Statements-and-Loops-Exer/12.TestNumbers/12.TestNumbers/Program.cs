using System;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int totalSum = 0;
            int counter = 0;

                for (int i = n; i >= 1; i--)
                {
                    for (int j = 1; j <= m; j++)
                    {
                    
                    if (totalSum >= boundary)
                    {
                        break;
                    }
                    else
                    {
                        totalSum += (i * j) * 3;
                    }
                    counter++;
                }
                if (totalSum >= boundary)
                {
                    break;
                }
            }

            if (totalSum >= boundary)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
