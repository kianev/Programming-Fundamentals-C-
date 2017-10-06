using System;

namespace _02.ReverseArrayofIntegers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}