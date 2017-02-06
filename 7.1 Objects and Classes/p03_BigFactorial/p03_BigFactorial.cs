using System;
using System.Numerics;

namespace p03_BigFactorial
{
    class p03_BigFactorial
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(input));
        }
        private static BigInteger Factorial(int n)
        {
            int num = 1;
            do
            {
                num = num * n;
                n--;
            } while (n > 1);

            return num;
        }
    }
}
