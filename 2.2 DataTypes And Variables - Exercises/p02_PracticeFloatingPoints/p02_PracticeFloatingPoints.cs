using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_PracticeFloatingPoints
{
    class p02_PracticeFloatingPoints
    {
        static void Main(string[] args)
        {
            double dobNum = double.Parse(Console.ReadLine());
            double flNum = double.Parse(Console.ReadLine());
            decimal decNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine(dobNum);
            Console.WriteLine(flNum);
            Console.WriteLine(decNum);
        }
    }
}
