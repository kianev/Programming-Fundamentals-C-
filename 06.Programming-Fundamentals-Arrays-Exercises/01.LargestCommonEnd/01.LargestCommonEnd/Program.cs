using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int lenght = Math.Min(arr1.Length, arr2.Length);
            int counter = 0;
            bool firstWordMatch = false;

            for (int i = 0; i < lenght; i++)
            {
                if (arr1[0] == arr2[0])
                {
                    if (arr1[i] == arr2[i])
                    {
                        counter++;
                        firstWordMatch = true;
                    }
                }
                else
                {
                    break;
                }
            }

            if (!firstWordMatch)
            {
                string[] arr1Rev = arr1.Reverse().ToArray();
                string[] arr2Rev = arr2.Reverse().ToArray();

                for (int i = 0; i < lenght; i++)
                {
                    if (arr1Rev[0] == arr2Rev[0])
                    {
                        if (arr1Rev[i] == arr2Rev[i])
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}