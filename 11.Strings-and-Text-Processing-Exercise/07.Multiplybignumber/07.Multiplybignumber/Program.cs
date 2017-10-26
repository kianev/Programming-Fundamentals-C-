using System;
using System.Linq;
using System.Text;

namespace _07.Multiplybignumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart(new char[] { '0' }); 
            int second = int.Parse(Console.ReadLine().TrimStart(new char[] { '0' }));

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var reminder = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = (first[i] - 48) * second + reminder;

                if (sum > 9)
                {
                    if (i == 0)
                    {
                        sb.Append(sum % 10);
                        sb.Append(sum / 10);
                    }
                    else
                    {
                        reminder = sum / 10;
                        sum = sum % 10;
                        sb.Append(sum);
                    }
                }
                else
                {
                    reminder = 0;
                    sb.Append(sum);
                }
            }

            string reversed = new string(sb.ToString().ToCharArray().Reverse().ToArray()).TrimStart('0');
            Console.WriteLine(reversed);
        }
    }
}