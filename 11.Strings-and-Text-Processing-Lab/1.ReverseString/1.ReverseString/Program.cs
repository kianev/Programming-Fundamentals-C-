using System;
using System.Text;

namespace _1.ReverseString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            sb.ToString();

            Console.WriteLine(sb);
        }
    }
}