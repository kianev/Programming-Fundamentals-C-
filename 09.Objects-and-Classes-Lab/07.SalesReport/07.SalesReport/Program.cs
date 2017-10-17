using System;
using System.Linq;

namespace _07.SalesReport
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                sales[i] = GetSale();
            }

            string[] towns = sales
                .Select(x => x.Town)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            foreach (var town in towns)
            {
                double salesByTown = sales
                    .Where(x => x.Town == town)
                    .Select(x => x.Price * x.Quantity)
                    .Sum();

                Console.WriteLine("{0} -> {1:F2}", town, salesByTown);
            }
        }

        private static Sale GetSale()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Sale sale = new Sale()
            {
                Town = input[0],
                Product = input[1],
                Price = double.Parse(input[2]),
                Quantity = double.Parse(input[3])
            };

            return sale;
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}