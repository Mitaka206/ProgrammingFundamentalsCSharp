using System;
using System.Numerics;

namespace p14_FactorialTrailingZeroes
{
    class p14_FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(GetTrailingZeroes(Factorial(n)));

            //string strngNum = Factorial(n).ToString();-----------------------------

            //int count = 0;

            //foreach (var nums in strngNum)
            //{
            //    var digit = nums - '0';

            //    if (digit == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count); ------------------//is All zeroes-------------

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
        static int GetTrailingZeroes(BigInteger num)
        {

            BigInteger timesZero = 0;

            while (num % 10 == 0)
            {
                num = num / 10;
                timesZero++;
            }

            return (int)timesZero;
        }
    }
}
