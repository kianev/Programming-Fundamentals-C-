using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                switch (command[0])
                {
                    case "Delete":
                        int numberToDel = int.Parse(command[1]);
                        numbers.RemoveAll(x => x == numberToDel);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, numberToInsert);
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }

            if (command[0] == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else if(command[0] == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }
}