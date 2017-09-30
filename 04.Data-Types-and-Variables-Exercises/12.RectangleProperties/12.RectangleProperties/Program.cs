using System;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double perimeter = 2 * (a + b);
            double area = a * b;
            double diagonal = (double)Math.Sqrt((double)Math.Pow(a,2) + (double)Math.Pow(b, 2));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
