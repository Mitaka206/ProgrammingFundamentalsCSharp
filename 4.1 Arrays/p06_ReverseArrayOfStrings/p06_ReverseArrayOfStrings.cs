using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_ReverseArrayOfStrings
{
    class p06_ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
