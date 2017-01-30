using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_SquareNumbers
{
    class p06_SquareNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var output = input.RemoveAll(x => Math.Sqrt(x) != 0);

            Console.WriteLine(string.Join(" ", output));//fuck
        }
    }
}
