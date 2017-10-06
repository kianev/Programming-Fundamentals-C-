using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool hasSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int a = arr[i];
                    int b = arr[j];
                    int sum = a + b;
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", a, b, sum);
                        hasSum = true;
                    }
                }
            }

            if (!hasSum)
                Console.WriteLine("No");
        }
    }
}
