using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesandRev
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> positives = new List<int>();

            foreach (var num in nums)
            {
                if (num >= 0)
                {
                    positives.Add(num);
                }
            }


            if(positives.Count > 0)
            {
                for (int i = positives.Count - 1; i >= 0; i--)
                {
                    Console.Write(positives[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
            
            

        }
    }
}
