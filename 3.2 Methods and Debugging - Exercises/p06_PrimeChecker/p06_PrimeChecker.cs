using System;

namespace p06_PrimeChecker
{
    class p06_PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        public static bool IsPrime(long number)
        {
            if (number == 1 && number == 0) return false;
            if (number == 2) return true;

            int fibonachi = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= fibonachi; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
