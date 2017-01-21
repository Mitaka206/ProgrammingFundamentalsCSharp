using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p18_DifferentIntegersSize
{
    class p18_DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            bool isSbyte = (input <= sbyte.MaxValue && input >= sbyte.MinValue);
            bool isByte = (input <= byte.MaxValue && input >= byte.MinValue);
            bool isShort = (input <= short.MaxValue && input >= short.MinValue);
            bool isUshort = (input <= ushort.MaxValue && input >= ushort.MinValue);
            bool isInt = (input <= int.MaxValue && input >= int.MinValue);
            bool isUint = (input <= uint.MaxValue && input >= uint.MinValue);
            bool islong = (input <= long.MaxValue && input >= long.MinValue);
            bool isUlong = (input <= ulong.MaxValue && input >= ulong.MinValue);

            
            if (isSbyte || isByte || isShort || isUshort || isInt || isUint || islong || isUlong)
            {
                Console.WriteLine($"{input} can fit in:");

                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (islong)
                {
                    Console.WriteLine("* long");
                }
                else if (isUlong)
                {
                    Console.WriteLine("* ulong");
                }
            }
            else
            {
                Console.WriteLine($"{input}");
                Console.WriteLine("can't fit in any type");
            }
        }
    }
}
