using System;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if(number == Math.Floor(number))
            {
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                    return;
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                    return;
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                    return;
                }
            }
            else 
            {
                Console.WriteLine("Rainy");
                return;
            }
        }
    }
}
