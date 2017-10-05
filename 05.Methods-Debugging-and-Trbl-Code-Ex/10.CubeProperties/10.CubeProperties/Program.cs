using System;

namespace _10.CubeProperties
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string param = Console.ReadLine();

            double result = 0.0;

            switch(param)
            {
                case "face":
                    result = CalcFace(side);
                    break;
                case "space":
                    result = CalcSpace(side);
                    break;
                case "volume":
                    result = CalcVolume(side);
                    break;
                case "area":
                    result = CalcArea(side);
                    break;
            }

            Console.WriteLine($"{result:f2}");
        }

       

        private static double CalcFace(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }

        private static double CalcSpace(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }

        private static double CalcVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        private static double CalcArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }
    }
}