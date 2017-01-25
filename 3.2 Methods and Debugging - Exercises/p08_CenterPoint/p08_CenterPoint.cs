using System;

namespace p08_CenterPoint
{
    class p08_CenterPoint
    {
        static void Main(string[] args)
        {

            var x1 = double.Parse(Console.ReadLine());//3
            var x2 = double.Parse(Console.ReadLine());//4
            
            var y1 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            
            if (DistanceToZero(x1, x2) < DistanceToZero(y1, y2))
            {
                Console.WriteLine($"({x1}, {x2})");
            }
            else
            {
                Console.WriteLine($"({y1}, {y2})");
            }
        }

        public static double DistanceToZero(double x1, double x2)
        {
            double dist = Math.Sqrt(Math.Abs(x1 * x1 + x2 * x2));

            return dist;
        }
    }
}
