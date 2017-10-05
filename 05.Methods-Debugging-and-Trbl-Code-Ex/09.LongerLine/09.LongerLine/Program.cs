using System;

namespace _08.CenterPoint
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double line1x1 = double.Parse(Console.ReadLine());
            double line1y1 = double.Parse(Console.ReadLine());
            double line1x2 = double.Parse(Console.ReadLine());
            double line1y2 = double.Parse(Console.ReadLine());
            double line2x1 = double.Parse(Console.ReadLine());
            double line2y1 = double.Parse(Console.ReadLine());
            double line2x2 = double.Parse(Console.ReadLine());
            double line2y2 = double.Parse(Console.ReadLine());

            double dist1 = CalcDistance(line1x1, line1y1, line1x2, line1y2);
            double dist2 = CalcDistance(line2x1, line2y1, line2x2, line2y2);

            if(dist1 > dist2)
            {
                PrintClosestPointToZero(line1x1, line1y1, line1x2, line1y2);
            }
            else if(dist1 < dist2)
            {
                PrintClosestPointToZero(line2x1, line2y1, line2x2, line2y2);
            }
            else if(dist1 == dist2) 
            {
                PrintClosestPointToZero(line1x1, line1y1, line1x2, line1y2);
            }
        }

        private static double CalcDistance(double x1, double y1, double x2, double y2)
        {

            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
           
        }

        private static void PrintClosestPointToZero(double x1, double y1, double x2, double y2)
        {

            double distPoint1 = CalcDistance(x1, y1, 0, 0);
            double distPoint2 = CalcDistance(x2, y2, 0, 0);
           

            if (distPoint1 <= distPoint2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}