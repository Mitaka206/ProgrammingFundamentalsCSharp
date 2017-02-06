using System;
using System.Numerics;

namespace p03_BigFactorial
{
    class p03_BigFactorial
    {
        static void Main(string[] args)
        {
            BigInteger nput = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(nput));
        }

        private static BigInteger Factorial(BigInteger n)
        {
            BigInteger num = 1;
            do
            {
                num = num * n;
                n--;
            } while (n > 1);

            return num;
        }
    }
}
