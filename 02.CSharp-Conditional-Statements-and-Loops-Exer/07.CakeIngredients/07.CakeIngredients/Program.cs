using System;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int counter = 0;

            while(command != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {command}.");
                counter++;
                command = Console.ReadLine();
            }

            if(command == "Bake!")
            {
                Console.WriteLine($"Preparing cake with {counter} ingredients.");
            }
        }
    }
}
