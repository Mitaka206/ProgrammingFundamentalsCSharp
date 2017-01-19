using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_RectangleProperties
{
    class p12_RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigt = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * heigt;
            double area = width * heigt;
            double diagonal = Math.Sqrt(width * width + heigt * heigt);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
