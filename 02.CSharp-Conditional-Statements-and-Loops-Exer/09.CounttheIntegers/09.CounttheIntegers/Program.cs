using System;

namespace _09.CounttheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int n;
            int counter = 0;

            while(int.TryParse(input, out n))
            {
                counter++;
                input = Console.ReadLine();
            }

            if(!int.TryParse(input, out n))
            {
                Console.WriteLine(counter);
            }
           

      
        }
    }
}
