using System;

namespace _9.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());
            int n = 10;

            if(startNumber < 10)
            {
                for (int i = startNumber; i <= n; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine($"{number} X {startNumber} = {number * startNumber}");
            }
          
        }
    }
}
