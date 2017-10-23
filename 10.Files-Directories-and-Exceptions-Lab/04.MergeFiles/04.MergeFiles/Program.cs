using System;
using System.IO;

namespace _04.MergeFiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileOne = File.ReadAllText("FileOne.txt");
            string fileTwo = File.ReadAllText("FileTwo.txt");

            File.WriteAllText("output.txt", fileOne);
            File.AppendAllText("output.txt", Environment.NewLine + fileTwo);
        }
    }
}