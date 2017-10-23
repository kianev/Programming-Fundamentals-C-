using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] lines = File.ReadAllLines("Input.txt");

            var oddLines = lines.Where((line, i) => i % 2 == 1);

            File.WriteAllLines("odd-lines.txt", oddLines);
        }
    }
}
