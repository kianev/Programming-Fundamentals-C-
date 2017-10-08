using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] arr2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            bool arr1First = false;
            bool arr2First = false;

            int length = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    arr1First = true;
                    break;
                }
                else if (arr1[i] > arr2[i])
                {
                    arr2First = true;
                    break;
                }
                else if (arr1[i] == arr2[i])
                {
                    continue;
                }
            }

            if (!arr1First && !arr2First && arr1.Length != arr2.Length)
            {
                if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
                else
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
            }
            else if (!arr1First && !arr2First && arr1.Length == arr2.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else
            {
                if (arr1First)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
                else if (arr2First)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
            }
        }
    }
}