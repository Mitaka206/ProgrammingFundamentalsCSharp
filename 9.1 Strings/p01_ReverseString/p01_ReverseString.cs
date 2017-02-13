using System;
using System.Linq;

namespace p01_ReverseString
{
    class p01_ReverseString
    {
        static void Main(string[] args)
        { 
            var input = Console.ReadLine().Reverse().ToList();

            Console.WriteLine(string.Join("", input));
        }
    }
}
