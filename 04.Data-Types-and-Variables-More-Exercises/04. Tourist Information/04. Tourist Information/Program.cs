using System;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            decimal value = decimal.Parse(Console.ReadLine());

            switch(unit)
            {
                case "miles":
                    Console.WriteLine($"{value} {unit} = {value * (decimal)1.6f:F2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} {unit} = {value * (decimal)2.54f:F2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} {unit} = {value * (decimal)30f:F2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} {unit} = {value * (decimal)0.91f:F2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} {unit} = {value * (decimal)3.8f:F2} liters");
                    break;
            }
        }
    }
}
