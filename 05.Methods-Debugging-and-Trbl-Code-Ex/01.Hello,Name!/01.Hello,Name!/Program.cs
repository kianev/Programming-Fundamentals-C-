using System;

namespace _01.Hello_Name_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}