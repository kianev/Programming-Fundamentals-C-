using System;

namespace _11.GeometryCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            double result = 0.0;

            switch (shape)
            {
                case "triangle":
                    double sideT = double.Parse(Console.ReadLine());
                    double heightT = double.Parse(Console.ReadLine());
                    result = CalcTriangleArea(sideT, heightT);
                    break;

                case "square":
                    double sideS = double.Parse(Console.ReadLine());
                    result = CalcSquareArea(sideS);
                    break;

                case "rectangle":
                    double widthR = double.Parse(Console.ReadLine());
                    double heightR = double.Parse(Console.ReadLine());
                    result = CalcRectangleArea(widthR, heightR);
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    result = CalcCircleArea(radius);
                    break;
            }

            Console.WriteLine($"{result:f2}");
        }

        private static double CalcTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        private static double CalcSquareArea(double side)
        {
            return (side * side);
        }

        private static double CalcRectangleArea(double width, double height)
        {
            return (width * height);
        }

        private static double CalcCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}