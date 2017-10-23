using System;
using System.IO;

namespace _06.FixEmails
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var name = lines[i];
                var email = lines[i + 1];

                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }

                var output = $"{lines[i]} -> {lines[i + 1]}";

                File.AppendAllText("output.txt", output + Environment.NewLine);
            }
        }
    }
}