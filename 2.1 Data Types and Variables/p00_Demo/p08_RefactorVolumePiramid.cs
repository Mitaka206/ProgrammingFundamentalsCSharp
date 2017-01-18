using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_RefactorVolumePiramid
{
    class p08_RefactorVolumePiramid
    {
        static void Main(string[] args)
        {
            double length, wight, height = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            wight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double s = (length * wight * height) / 3;

            Console.WriteLine($"Pyramid Volume: {s:F2}");
        }
    }
}
