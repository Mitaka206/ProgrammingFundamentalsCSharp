using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea2D
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var area = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            var Perimeter = (Math.Abs(x2 - x1) + Math.Abs(y2 - y1))*2;

            Console.WriteLine(area);
            Console.WriteLine(Perimeter);

        }
    }
}
