using System;
using System.Linq;

namespace p05_SortNumbers
{
    class p05_SortNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            input.Sort();

            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
