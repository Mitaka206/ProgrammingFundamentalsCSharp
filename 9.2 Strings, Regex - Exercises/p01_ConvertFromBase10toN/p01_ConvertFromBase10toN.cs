using System;
using System.Linq;
using System.Numerics;
namespace p01_ConvertFromBase10toN
{
    class p01_ConvertFromBase10toN
    {
        static void Main(string[] args)
        {
            var read = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            var n = read[0];
            var number = read[1];
           
            BigInteger remainder = 0;
            string result = string.Empty;

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    remainder = number % n;
                    number /= n;
                    result = string.Concat(remainder.ToString(), result);
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
