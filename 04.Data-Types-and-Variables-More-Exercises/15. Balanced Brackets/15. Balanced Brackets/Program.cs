using System;

namespace _15.Balanced_Brackets
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            byte openingBrackets = 0;
            byte closingBrachets = 0;
            bool nested = false;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char current = char.Parse(input);
                    openingBrackets += current == '(' ? (byte)1 : (byte)0;
                    closingBrachets += current == ')' ? (byte)1 : (byte)0;

                    if (!(openingBrackets == closingBrachets || openingBrackets == closingBrachets + 1))
                    {
                        nested = true;
                    }
                }
            }

            bool isBalanced = openingBrackets == closingBrachets;
            Console.WriteLine(isBalanced && !nested ? "BALANCED" : "UNBALANCED");
                
        }
    }
}