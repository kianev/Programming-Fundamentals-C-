using System;

namespace _01.ChooseaDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();
            string drink = "";

            switch (profession)
            {
                case "athlete":
                    drink = "Water";
                    break;
                case "businessman":
                    drink = "Coffee";
                    break;
                case "businesswoman":
                    drink = "Coffee";
                    break;
                case "softuni student":
                    drink = "Beer";
                    break;
                default: drink = "Tea";
                    break;

            }

            Console.WriteLine(drink);
        }
        }
    }

