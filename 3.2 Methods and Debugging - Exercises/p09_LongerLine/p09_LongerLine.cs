using System;

namespace p09_LongerLine
{
    class p09_LongerLine
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());//3
            var x2 = double.Parse(Console.ReadLine());//4

            var y1 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var z1 = double.Parse(Console.ReadLine());
            var z2 = double.Parse(Console.ReadLine());

            var f1 = double.Parse(Console.ReadLine());
            var f2 = double.Parse(Console.ReadLine());

            //double dist1 = Math.Max(DistanceToZero(x1, x2), DistanceToZero(y1, y2));
            //double dist2 = Math.Max(DistanceToZero(z1, z2), DistanceToZero(f1, f2));

            //double maxDist1 = Math.Max(dist1, dist2);

            //double dist3 = Math.Max(DistanceToZero(z1, z2), DistanceToZero(y1, y2));
            //double dist4 = Math.Max(DistanceToZero(x1, x2), DistanceToZero(f1, f2));

            //double maxDist2 = Math.Min(dist1, dist2);
            
        }

        public static double DistanceToZero(double x1, double x2)
        {
            double dist = Math.Sqrt(Math.Abs(x1 * x1 + x2 * x2));

            return dist;
        }
    }
}
