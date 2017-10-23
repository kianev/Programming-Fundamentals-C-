using System;
using System.IO;

namespace _09.IndexofLetters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputFile = File.ReadAllText("input.txt");
            File.Delete("output.txt");

            var infoFile = new FileInfo("input.txt");

            File.WriteAllText("output", "");
            for (int i = 0; i < infoFile.Length; i++)
            {
                var output = $"{inputFile[i]} -> {(int)inputFile[i] - 97}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);

            }
        }
    }
}