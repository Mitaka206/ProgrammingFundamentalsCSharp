using System;
using System.Linq;

namespace p04_Largest3Numbers
{
    class p04_Largest3Numbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ",
                input.OrderByDescending(n => n)
                .Take(3)));
        }
    }
}
