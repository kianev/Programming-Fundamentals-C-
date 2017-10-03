using System;

namespace _5.TemperatureConv
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = FahrenheitToCel(fahrenheit);
            Console.WriteLine("{0:F2}", celsius);
        }

        static double FahrenheitToCel(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}