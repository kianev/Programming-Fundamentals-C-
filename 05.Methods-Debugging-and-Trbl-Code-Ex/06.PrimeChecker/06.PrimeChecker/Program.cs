using System;

namespace Prime_Checker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isPrime = false;
            isPrime = IsPrime(isPrime);
            Console.WriteLine(isPrime);
        }

        public static bool IsPrime(bool isPrime)
        {
            long number = long.Parse(Console.ReadLine());
            number = Math.Abs(number);
            double range = Math.Sqrt(number);

            isPrime = true;

            if (number < 2)
            {
                isPrime = false;
                return isPrime;
            }
            else
            {
                for (long i = 2; i <= range; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                return isPrime;
            }
            else
            {
                return isPrime;
            }
        }
    }
}