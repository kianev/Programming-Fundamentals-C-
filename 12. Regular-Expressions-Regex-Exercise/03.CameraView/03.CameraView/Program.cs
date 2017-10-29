using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = nums[0];
            int take = nums[1];

            string pattern = "\\|<(\\w{" + skip + "})(\\w{0," + take + "})";
            string input = Console.ReadLine();

            var matchedViews = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            foreach (Match view in matchedViews)
            {
                result.Add(view.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}