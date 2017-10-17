using System;
using System.Globalization;

namespace _01.DayofWeek
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}