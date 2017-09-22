using System;

namespace _11.OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num % 2 == 0)
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Please write an odd number.");

            }

            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
            
        }
    }

