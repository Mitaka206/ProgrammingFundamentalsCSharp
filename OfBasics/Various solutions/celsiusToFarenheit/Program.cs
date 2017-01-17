using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", C * 1.8 + 32);

        }
    }
}
