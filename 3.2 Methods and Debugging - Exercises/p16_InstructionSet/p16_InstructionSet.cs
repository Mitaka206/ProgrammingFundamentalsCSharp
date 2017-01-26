using System;

namespace p16_InstructionSet
{
    class p16_InstructionSet
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long operandOne = 0;
                long operandTwo = 0;

                long result = 0;


                if (codeArgs[0].Equals("INC"))
                {
                    operandOne = long.Parse(codeArgs[1]);
                    result = operandOne + 1;
                }
                else if (codeArgs[0].Equals("DEC"))
                {
                    operandOne = long.Parse(codeArgs[1]);
                    result = operandOne - 1;
                }
                else if (codeArgs[0].Equals("ADD"))
                {
                    operandOne = long.Parse(codeArgs[1]);
                    operandTwo = long.Parse(codeArgs[2]);
                    result = operandOne + operandTwo;
                }
                else if (codeArgs[0].Equals("MLA"))
                {
                    operandOne = long.Parse(codeArgs[1]);
                    operandTwo = long.Parse(codeArgs[2]);
                    result = operandOne * operandTwo;
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}
