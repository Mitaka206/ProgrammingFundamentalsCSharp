using System;
using System.Linq;

namespace p03_IntersectionOfCircles
{
    class p03_IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstCenter = new Point(firstInput[0], firstInput[1]);
            Point secondCenter = new Point(secondInput[0], secondInput[1]);

            Circle firstCircle = new Circle(firstCenter, firstInput[2]);
            Circle secondCircle = new Circle(secondCenter, secondInput[2]);

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
