using System;
using System.Numerics;

namespace Exe16InstructionSet
{
    class InstructionSet
    {
        static void Main()
        {
            string opCode = Console.ReadLine();
            BigInteger result = 0;
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }

        }
    }
}
