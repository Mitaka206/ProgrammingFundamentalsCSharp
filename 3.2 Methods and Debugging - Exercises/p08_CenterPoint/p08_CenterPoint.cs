using System;

namespace p08_CenterPoint
{
    class p08_CenterPoint
    {
        static void Main(string[] args)
        {

            var x1 = double.Parse(Console.ReadLine());//3
            var y1 = double.Parse(Console.ReadLine());//4
            
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            
            if (DistanceToZero(x1, y1) < DistanceToZero(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        public static double DistanceToZero(double x, double y)
        {
            double distance = Math.Sqrt(Math.Abs(x * x + y * y));

            return distance;
        }
    }
}
