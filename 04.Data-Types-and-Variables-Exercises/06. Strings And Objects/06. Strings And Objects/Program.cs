using System;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            object helloWorld = str1 + " " + str2;

            string str3 = (string)helloWorld;

            Console.WriteLine(str3);
        }
    }
}
