using System;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            short tankLiters = 0;

            for (int i = 0; i < n; i++)
            {
                short liters = short.Parse(Console.ReadLine());
                if(tankLiters + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankLiters += liters;
                }
            }

            Console.WriteLine(tankLiters);
        }
    }
}
