﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombParameters[0])
                {
                    for (int j = 1; j <= bombParameters[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }

                    for (int j = 1; j <= bombParameters[1]; j++)
                    {
                        if (i + j > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + j] = 0;
                        }
                    }

                    numbers[i] = 0;
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}