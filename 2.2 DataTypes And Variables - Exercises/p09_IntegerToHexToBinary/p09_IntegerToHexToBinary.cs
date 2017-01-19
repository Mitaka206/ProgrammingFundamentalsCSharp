using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_IntegerToHexToBinary
{
    class p09_IntegerToHexToBinary
    {
        static void Main(string[] args)
        {
            int intValue = int.Parse(Console.ReadLine());

            string hexValue = Convert.ToString(intValue, 16);
            string binaryValue = Convert.ToString(intValue, 2);

            Console.WriteLine("{0}", hexValue.ToUpper());
            Console.WriteLine("{0}", binaryValue);
        }
    }
}
