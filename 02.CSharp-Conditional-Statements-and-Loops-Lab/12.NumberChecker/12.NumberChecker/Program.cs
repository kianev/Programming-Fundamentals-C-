﻿using System;

namespace _12.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
