using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double totalPrice = 0.0;
            string hall = "";

            if (people <= 50)
            {
                hall = "Small Hall";
                totalPrice += 2500;

            }
            else if(people > 50 && people <= 100)
            {
                hall = "Terrace";
                totalPrice += 5000;
            }
            else if(people > 100 && people <= 120)
            {
                hall = "Great Hall";
                totalPrice += 7500;
            }


            switch (package)
            {
                case "Normal":
                    if (totalPrice > 0)
                    {
                        totalPrice += 500;
                        totalPrice = totalPrice - totalPrice * 0.05;
                    }
                        break;
                    
                case "Gold":
                    if (totalPrice > 0)
                    {
                        totalPrice += 750;
                        totalPrice = totalPrice - totalPrice * 0.10;
                    }
                    break;
                case "Platinum":
                    if (totalPrice > 0)
                    {
                        totalPrice += 1000;
                        totalPrice = totalPrice - totalPrice * 0.15;
                    }
                    break;
            }

            if(totalPrice > 0)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {totalPrice / people:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

           
          }
        }
    }

