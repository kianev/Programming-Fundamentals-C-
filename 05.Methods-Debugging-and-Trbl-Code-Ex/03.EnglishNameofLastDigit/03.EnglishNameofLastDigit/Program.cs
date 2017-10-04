using System;

namespace _03.EnglishNameofLastDigit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            PrintLastDigit(Math.Abs(number));
        }

        private static void PrintLastDigit(long number)
        {
            long lastDigit = number % 10;
            string numberWord = "";

            switch(lastDigit)
            {
                case 0:
                    numberWord = "zero";
                    break;
                case 1:
                    numberWord = "one";
                    break;
                case 2:
                    numberWord = "two";
                    break;
                case 3:
                    numberWord = "three";
                    break;
                case 4:
                    numberWord = "four";
                    break;
                case 5:
                    numberWord = "five";
                    break;
                case 6:
                    numberWord = "six";
                    break;
                case 7:
                    numberWord = "seven";
                    break;
                case 8:
                    numberWord = "eight";
                    break;
                case 9:
                    numberWord = "nine";
                    break;
            }

            Console.WriteLine(numberWord);
        }
    }
}