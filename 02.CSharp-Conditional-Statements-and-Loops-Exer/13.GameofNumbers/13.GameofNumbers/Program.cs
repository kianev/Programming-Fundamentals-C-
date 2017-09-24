using System;


namespace _13.GameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            int found = 0;

            int first = 0;
            int second = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if((i + j) == magicNumber)
                    {
                        first = i;
                        second = j;
                        found += 1;
                        counter++;
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }

            if(found == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
            else
            {
                Console.WriteLine($"Number found! {first} + {second} = {magicNumber}");
            }
        }
    }
}
