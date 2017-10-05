using System;

namespace _08.CenterPoint
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, x2, y1, y2);
        }

        private static void PrintClosestPoint(double x1, double x2, double y1, double y2)
        {
            if (Math.Abs(x1) < Math.Abs(y1) && Math.Abs(x2) < Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {x2})");
            }
            else
            {
                Console.WriteLine($"({y1}, {y2})");
            }
           
        }
    }
}