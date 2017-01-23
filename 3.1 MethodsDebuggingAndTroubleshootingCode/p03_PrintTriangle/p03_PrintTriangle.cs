using System;

namespace p03_PrintTriangle
{
    class p03_PrintTriangle
    {
        static void Main(string[] args)
        {
            int coutTriangle = int.Parse(Console.ReadLine());

            PrintTriangle(coutTriangle);
        }

        private static void PrintTriangle(int coutTriangle)
        {
            for (int i = 1; i <= coutTriangle; i++)
            {
                RepeadDigit(i);
            }
            for (int j = coutTriangle - 1; j >= 0; j--)
            {
                RepeadDigit(j);
            }
        }

        private static void RepeadDigit(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
