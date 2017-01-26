using System;

namespace p16_InstructionSet
{
    class p16_InstructionSet
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();

            while (opCode != "end")
            {
                string[] codeArgs = opCode.Split(' ');

                int operandOne = 0;
                int operandTwo = 0;

                long result = 0;


                if (codeArgs[0].Equals("INC"))
                {
                    operandOne = int.Parse(codeArgs[1]);
                    result = operandOne++;
                }
                else if (codeArgs[0].Equals("DEC"))
                {
                    operandOne = int.Parse(codeArgs[1]);
                    result = operandOne--;
                }
                else if (codeArgs[0].Equals("ADD"))
                {
                    operandOne = int.Parse(codeArgs[1]);
                    operandTwo = int.Parse(codeArgs[2]);
                    result = operandOne + operandTwo;
                }
                else if (codeArgs[0].Equals("MLA"))
                {
                    operandOne = int.Parse(codeArgs[1]);
                    operandTwo = int.Parse(codeArgs[2]);
                    result = (long)(operandOne * operandTwo);
                }
                // si to big

                Console.WriteLine(result);
            }
        }
    }
}
