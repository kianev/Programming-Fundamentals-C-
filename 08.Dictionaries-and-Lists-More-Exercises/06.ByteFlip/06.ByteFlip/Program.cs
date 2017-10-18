using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hexaArray = Console.ReadLine().Split(' ').ToArray();

            List<string> selectedArray = new List<string>();

            foreach (var item in hexaArray)
            {
                if(item.Length == 2)
                {
                    string reversed = new string(item.ToCharArray().Reverse().ToArray());
                    string converted = System.Convert.ToChar(System.Convert.ToUInt32(reversed, 16)).ToString();
                    selectedArray.Add(converted);
                }
            }

            selectedArray.Reverse();

            Console.WriteLine(string.Join("", selectedArray));
        }
    }
}
