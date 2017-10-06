using System;

namespace _03.LastKNumbersSums
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                if (i <= k)
                {
                    for (int j = 0; j < i; j++)
                    {
                        seq[i] += seq[j];
                    }
                }
                else
                {
                    for (int j = i - k; j <= i - 1 ; j++)
                    {
                        seq[i] += seq[j];
                    }
                }
            }

            foreach (var element in seq)
                Console.WriteLine(element);

        }
    }
}