﻿using System;
using System.Linq;

namespace _5.ArrayManipulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandArgs[1]), commandArgs
                        .Skip(2)
                        .Select(int.Parse)
                        .ToArray());
                }
                else if (commandArgs[0] == "contains")
                {
                    int number = int.Parse(commandArgs[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine(numbers.IndexOf(number));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "shift")
                {
                    int number = int.Parse(commandArgs[1]);
                    number = number % numbers.Count;
                    var reminder = numbers.Take(number).ToList();
                    numbers.RemoveRange(0, number);
                    numbers.AddRange(reminder);
                }
                else if (commandArgs[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}