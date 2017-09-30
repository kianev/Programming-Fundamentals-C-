using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            
            seconds += minutes * 60 + hours * 3600;

            float mps = (float)meters / seconds;
            float kph = ((float)meters / 1000) / ((float)seconds / 3600);
            float mph = ((float)meters / 1609) / ((float)seconds / 3600);

            Console.WriteLine($"{mps}");
            Console.WriteLine(kph);
            Console.WriteLine(mph);
        }
    }
}
