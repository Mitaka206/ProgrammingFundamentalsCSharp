using System;

namespace p11_GeometryCalculator
{
    class p11_GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            double area = AreaOf(figure);

            Console.WriteLine($"{area:f2}");
        }

        private static double AreaOf(string figure)
        {
            double area = 0;

            switch (figure)
            {
                case "triangle":
                    double a = double.Parse(Console.ReadLine());
                    double ha = double.Parse(Console.ReadLine());
                    area = a * ha / 2;
                    break;
                case "square":
                    double b = double.Parse(Console.ReadLine());
                    area = b * b;
                    break;
                case "rectangle":
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    area = c * d;
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * r * r;
                    break;
            }

            return area;
        }
    }
}
