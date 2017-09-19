using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name bitch?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello ${0}! ", name);
        }
    }
}
