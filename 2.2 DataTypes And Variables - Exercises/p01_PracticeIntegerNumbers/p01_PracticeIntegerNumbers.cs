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
            int sbytNum = int.Parse(Console.ReadLine());
            int byteNum = int.Parse(Console.ReadLine());
            int shortNum = int.Parse(Console.ReadLine());
            int ushortNum = int.Parse(Console.ReadLine());
            long uintNum = long.Parse(Console.ReadLine());
            long intNum = long.Parse(Console.ReadLine());
            long longNum = long.Parse(Console.ReadLine());

            Console.WriteLine($"{sbytNum}");
            Console.WriteLine($"{byteNum}");
            Console.WriteLine($"{ shortNum}");
            Console.WriteLine($"{ ushortNum}");
            Console.WriteLine($"{ uintNum}");
            Console.WriteLine($"{ intNum}");
            Console.WriteLine($"{ longNum}");
        }
    }
}
