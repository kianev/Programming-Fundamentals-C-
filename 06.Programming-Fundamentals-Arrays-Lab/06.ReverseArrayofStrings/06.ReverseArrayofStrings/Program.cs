using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string[] inputReversed = input.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", inputReversed));
        }
    }
}
