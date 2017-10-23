using System;
using System.Linq;
using System.IO;

namespace _11.EqualSums
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            File.Delete("output.txt");

            bool hasNum = false;
            File.WriteAllText("output", "");

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText("output.txt", i.ToString());
                    hasNum = true;
                    break;
                }
            }

            if (!hasNum)
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}