using System;

namespace p06_MathPower
{
    class p06_MathPower
    {
        static void Main(string[] args)
        {
            double digit = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(digit, pow));
        }

        public static double MathPower(double x, int n)
        {
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                pow *= x;
            }
            return pow;
        }
    }
}
