using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16_ComparingFloats
{
    class p16_ComparingFloats
    {
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            bool isTrue = Math.Abs(numA - numB) < 0.0000009;

            if (isTrue)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Falce");
            }
            
        }
    }
}
