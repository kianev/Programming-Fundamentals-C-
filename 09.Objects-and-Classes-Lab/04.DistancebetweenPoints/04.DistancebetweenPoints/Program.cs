using System;
using System.Linq;

namespace _04.DistancebetweenPoints
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Point point1 = ReadPoint(Console.ReadLine());
            Point point2 = ReadPoint(Console.ReadLine());
            Console.WriteLine("{0:F3}", CalcPointDistance(point1, point2));
        }

        private static double CalcPointDistance(Point point1, Point point2)
        {
            int deltaX = point1.X - point2.X;
            int deltaY = point1.Y - point2.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private static Point ReadPoint(string input)
        {
            int[] pointInfo = input.Split(' ').Select(int.Parse).ToArray();

            Point p = new Point();
            p.X = pointInfo[0];
            p.Y = pointInfo[1];

            return p;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}