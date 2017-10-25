using System;
using System.Linq;
using System.Text;

namespace _03.UnicodeCharacters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}