using System;
using System.Numerics;

namespace p13_Factorial
{
    class p13_Factorial
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());
            
            Console.WriteLine(Factorial(n));
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
