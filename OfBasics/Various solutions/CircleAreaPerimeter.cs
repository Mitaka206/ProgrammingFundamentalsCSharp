using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Math.PI * r * r);
            Console.WriteLine("{0}", Math.PI * r * 2);
        }
    }
}
