using System;

namespace _12.Beer_Kegs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string kegModel = "";
            double biggestVolume = 0;


            
                while(n > 0)
            {
                
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;
                
                if(kegVolume > biggestVolume)
                {
                    kegModel = model;
                    biggestVolume = kegVolume;
                }
                n--;
            }

            Console.WriteLine(kegModel);
        }
    }
}