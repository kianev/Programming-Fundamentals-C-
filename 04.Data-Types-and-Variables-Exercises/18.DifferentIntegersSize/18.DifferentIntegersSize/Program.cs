using System;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool canFit = false;
            string message = "";

            try
            {
                sbyte sbyteNum = sbyte.Parse(num);
                message += "* sbyte\n";
                canFit = true;
            }
            catch(Exception)
            {
            }

            try
            {
                byte byteNum = byte.Parse(num);
                message += "* byte\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                short shortNum = short.Parse(num);
                message += "* short\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                ushort shortNum = ushort.Parse(num);
                message += "* ushort\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                int shortNum = int.Parse(num);
                message += "* int\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                uint shortNum = uint.Parse(num);
                message += "* uint\n";
                canFit = true;
            }
            catch (Exception)
            {
            }


            try
            {
                long shortNum = long.Parse(num);
                message += "* long\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            if (canFit)
            {
                Console.WriteLine("{0} can fit in:", num);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", num);
            }


        }
    }
}
