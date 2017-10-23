using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");

            var linesIndex = lines.Select((line, index) => $"{index + 1}. {line}");

            File.WriteAllLines("output.txt", linesIndex);
        }
    }
}