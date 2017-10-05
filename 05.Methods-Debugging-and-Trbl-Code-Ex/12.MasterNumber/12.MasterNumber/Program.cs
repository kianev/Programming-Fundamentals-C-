using System;

namespace _12.MasterNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                bool isPal = IsPalindrome(i);
                bool divBySeven = SumOfDigits(i);
                bool hasEven = ContainsEvenDigit(i);

                if (isPal == true && divBySeven == true && hasEven == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != sNum[sNum.Length - 1 - i]) return false;

            return true;
        }

        private static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 7 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            bool isEven = false;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    isEven = true;
                    break;
                }
                num /= 10;
            }

            if (isEven)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}