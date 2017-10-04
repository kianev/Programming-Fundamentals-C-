using System;

namespace _04.NumbersinReversedOrder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            ReverseNumber(Math.Abs(number));
        }

        private static void ReverseNumber(double number)
        {
            string numToReverse = Convert.ToString(number);
            
            string reversed = "";
            for (int i = numToReverse.Length - 1; i >= 0; i--)
            {
                reversed += numToReverse[i];
            }

            double reversedNum = Convert.ToDouble(reversed);


            Console.WriteLine(reversedNum);
        }
    }
}