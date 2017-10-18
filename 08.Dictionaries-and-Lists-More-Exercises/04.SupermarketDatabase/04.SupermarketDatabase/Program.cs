using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SupermarketDatabase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, double>> products =
                new Dictionary<string, Dictionary<double, double>>();

            double totalAmount = 0;

            string input = Console.ReadLine();

            while (input != "stocked")
            {
                string[] product = input.Split(' ').ToArray();

                string productName = product[0];
                double price = double.Parse(product[1]);
                double quantity = double.Parse(product[2]);

                if (!products.ContainsKey(productName))
                {
                    products[productName] = new Dictionary<double, double>();
                }

                if (!products[productName].ContainsKey(price))
                {
                    products[productName][price] = 0;
                }

                products[productName][price] += quantity;

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                string productName = product.Key;
                double price = product.Value.Keys.Last();
                double quantity = product.Value.Values.Sum();
                totalAmount += (price * quantity);

                Console.WriteLine($"{productName}: ${price:f2} * {quantity} = ${price * quantity:f2}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalAmount:f2}");
        }
    }
}