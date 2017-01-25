using System;

namespace p06_PrimeChecker
{
    class p06_PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool prime = IsPrime(n);

            Console.WriteLine(prime);
        }

        private static bool IsPrime(long n)
        {
            bool prime = true;

            if (n == 0 || n == 1)
            {
                prime = false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
            }

            return prime;
        }
    }
}
