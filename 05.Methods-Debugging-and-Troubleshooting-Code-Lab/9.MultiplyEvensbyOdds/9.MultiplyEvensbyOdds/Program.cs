using System;

namespace _9.MultiplyEvensbyOdds
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);
            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEven = GetSumOfEvenNumbers(number);
            int sumOdd = GetSumOfOddNumbers(number);
            return sumEven * sumOdd;
        }

        private static int GetSumOfOddNumbers(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        private static int GetSumOfEvenNumbers(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}