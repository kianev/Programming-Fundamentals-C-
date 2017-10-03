using System;

namespace _6.CalcTriangleArea
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = TriangleArea(width, height);

            Console.WriteLine(area);
        }

        private static double TriangleArea(double width, double height)
        {
            return (height * width) / 2;
        }
    }
}