using System;
using System.Numerics;

namespace p07_MultiplyBigNumber
{
    class p07_MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var firstNum = BigInteger.Parse(Console.ReadLine());
            var secondNum = BigInteger.Parse(Console.ReadLine());

            BigInteger multiply = BigInteger.Multiply(firstNum, secondNum);

            Console.WriteLine(multiply);
        }
    }
}
