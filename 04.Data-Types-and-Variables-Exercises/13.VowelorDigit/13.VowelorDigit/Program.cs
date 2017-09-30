using System;

namespace _13.VowelorDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int n;
            bool isNumeric = int.TryParse(input, out n);

            if (input == "a" || input == "o" || input == "e" || input == "i" || input == "u")
            {
                Console.WriteLine("vowel");
            }
            else if(isNumeric)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
