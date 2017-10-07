using System;
using System.Linq;

namespace _07.SumArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(arr1[i] + arr2[i] + " ");
                }
            }
            else
            {
                int maxLenght = Math.Max(arr1.Length, arr2.Length);

                for (int i = 0; i < maxLenght; i++)
                {
                    if (arr1.Length > arr2.Length)
                    {
                        Console.Write(arr1[i] + arr2[i % arr2.Length] + " ");
                    }
                    else
                    {
                        Console.Write(arr2[i] + arr1[i % arr1.Length] + " ");
                    }
                }
            }
        }
    }
}