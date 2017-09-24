using System;

namespace _01.ChooseaDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double waterPrice = 0.7;
            double coffeePrice = 1.0;
            double beerPrice = 1.70;
            double teaPrice = 1.20;

            double totalPrice = 0;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantity * waterPrice;
                    break;
                case "Businessman":
                    totalPrice = quantity * coffeePrice;
                    break;
                case "Businesswoman":
                    totalPrice = quantity * coffeePrice;
                    break;
                case "SoftUni Student":
                    totalPrice = quantity * beerPrice;
                    break;
                default:
                    totalPrice = quantity * teaPrice;
                    break;

            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}

