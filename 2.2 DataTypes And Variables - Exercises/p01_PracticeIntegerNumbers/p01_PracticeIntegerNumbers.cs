using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_PracticeIntegerNumbers
{
    class p01_PracticeIntegerNumbers
    {
        static void Main(string[] args)
        {
            sbyte sbytNum = sbyte.Parse(Console.ReadLine());
            byte byteNum = byte.Parse(Console.ReadLine());
            short shortNum = short.Parse(Console.ReadLine());
            ushort ushortNum = ushort.Parse(Console.ReadLine());
            long uintNum = long.Parse(Console.ReadLine());
            long intNum = long.Parse(Console.ReadLine());
            long longNum = long.Parse(Console.ReadLine());

            Console.WriteLine($"{sbytNum}\n\r{byteNum}\n\r{shortNum}\n\r{ushortNum}\n\r{uintNum}\n\r{intNum}\n\r{longNum}");
        }
    }
}
