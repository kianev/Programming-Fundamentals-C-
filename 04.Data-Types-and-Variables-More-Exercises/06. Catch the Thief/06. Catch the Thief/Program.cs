using System;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());

            long id = long.MinValue;

            switch (idType)
            {
                case "sbyte":
                    for (int i = 0; i < n; i++)
                    {
                        long inputId = long.Parse(Console.ReadLine());
                        if(inputId <= sbyte.MaxValue)
                        {
                            if(inputId >= id)
                            {
                                id = inputId;
                            }
                        }
                    }
                    break;

                case "int":
                    for (int i = 0; i < n; i++)
                    {
                        long inputId = long.Parse(Console.ReadLine());
                        if (inputId <= int.MaxValue)
                        {
                            if (inputId >= id)
                            {
                                id = inputId;
                            }
                        }
                    }
                    break;

                case "long":
                    for (int i = 0; i < n; i++)
                    {
                        long inputId = long.Parse(Console.ReadLine());
                        if (inputId <= long.MaxValue)
                        {
                            if (inputId >= id)
                            {
                                id = inputId;
                            }
                        }
                    }
                    break;

            }

            Console.WriteLine(id);
        }
    }
}
