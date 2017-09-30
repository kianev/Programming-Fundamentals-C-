using System;

namespace _08.House_Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());

            sbyte priceSbyte = 0;
            long priceInt = 0;

            if(num1 <= 127)
            {
                priceSbyte = (sbyte)num1;
                priceInt = (long)num2;
            }
            else
            {
                priceSbyte = (sbyte)num2;
                priceInt = (long)num1;
            }

            long totalPrice = (10 * priceInt) + (4 * priceSbyte);

            Console.WriteLine(totalPrice);
            
        }
    }
}