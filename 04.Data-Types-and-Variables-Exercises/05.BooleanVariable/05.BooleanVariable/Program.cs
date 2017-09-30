using System;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();

            bool result = Convert.ToBoolean(boolean);

            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
