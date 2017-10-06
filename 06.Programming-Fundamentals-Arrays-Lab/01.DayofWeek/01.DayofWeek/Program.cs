using System;

namespace _01.DayofWeek
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            if(n >= 1 && n <= 7)
            {
                Console.WriteLine(days[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
           
        }
    }
}