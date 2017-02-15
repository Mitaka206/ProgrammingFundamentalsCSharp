using System;
using System.Numerics;

namespace p06_SumBigNumbers
{
    class p06_SumBigNumbers
    {
        static void Main(string[] args)
        {
            var firstNum = BigInteger.Parse(Console.ReadLine());
            var secondNum = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = firstNum + secondNum;

            Console.WriteLine(sum);
        }
    }
}
