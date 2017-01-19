using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_HexFormat
{
    class p02_HexFormat
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();

            int toIntNum = Convert.ToInt32(hexNum, 16);

            Console.WriteLine(toIntNum);


            //return version
            //int intValue = int.Parse(Console.ReadLine());

            //string hexValue = intValue.ToString("X");

            //Console.WriteLine("0x{0}", hexValue);
        }
    }
}
