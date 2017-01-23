using System;

namespace p05_CalculateTriangleArea
{
    class p05_CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(width, height));
        }

        public static double TriangleArea(double b, double hb)
        {
            return b * hb / 2;
        }
    }
}
