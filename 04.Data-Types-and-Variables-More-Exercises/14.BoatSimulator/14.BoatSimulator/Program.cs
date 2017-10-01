using System;

namespace _14.BoatSimulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            byte lines = byte.Parse(Console.ReadLine());

            byte boat1Movement = 0;
            byte boat2Movement = 0;

            for (int i = 1; i <= lines; i++)
            {
                string command = Console.ReadLine();

                if(command == "UPGRADE")
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                }
                else
                {
                    if(i % 2 == 1)
                    {
                        boat1Movement += (byte)command.Length;
                        if(boat1Movement >= 50)
                        {
                            break;
                        }
                    }
                    else
                    {
                        boat2Movement += (byte)command.Length;
                        if (boat2Movement >= 50)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(boat1Movement > boat2Movement ? boat1 : boat2);
        }
    }
}