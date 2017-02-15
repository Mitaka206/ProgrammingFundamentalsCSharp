using System;
using System.Numerics;

namespace p02_ConvertFromBaseNToBase10
{
    class p02_ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            int N = int.Parse(input[0]);
            char[] number = input[1].ToCharArray();
            BigInteger result = new BigInteger(0);

            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(N), i));

                result += forSum;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
