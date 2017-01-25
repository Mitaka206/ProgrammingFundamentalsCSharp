using System;

namespace p05_FibonachiNumbers
{
    class p05_FibonachiNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FibonachiNum(n);
        }

        public static void FibonachiNum(int n)
        {
            int f0 = 1;
            int fibonachi = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int fn = f0 + fibonachi;
                f0 = fibonachi;
                fibonachi = fn;
            }

            Console.WriteLine(fibonachi);
        }
    }
}

