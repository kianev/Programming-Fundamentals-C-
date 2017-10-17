using System;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        private static void PrintDistance(Point[] closestPoints)
        {
            double distance = CalcPointDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine("{0:f3}", distance);
        }

        private static Point[] FindClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcPointDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }

            return closestTwoPoints;
        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        private static Point ReadPoint()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p = new Point() { X = array[0], Y = array[1] };

            return p;
        }

        private static double CalcPointDistance(Point point1, Point point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}