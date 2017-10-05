using System;
using System.Numerics;

internal class InstructionSet_broken
{
    private static void Main()
    {
        string opCode = Console.ReadLine();

        BigInteger result = 0;

        while (opCode != "end")
        {
            string[] codeArgs = opCode.Split(' ');

            switch (codeArgs[0].ToLower())
            {
                case "inc":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                case "dec":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                    }
                case "add":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "mla":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (BigInteger)operandOne * (BigInteger)operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
            opCode = Console.ReadLine().ToLower();

        }
    }
}