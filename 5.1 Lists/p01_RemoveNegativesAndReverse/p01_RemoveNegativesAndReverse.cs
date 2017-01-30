using System;
using System.Linq;

namespace p01_RemoveNegativesAndReverse
{
    class p01_RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            
                input.RemoveAll(x => x < 0);
                input.Reverse();
            if (input.Count > 0)
            {
                Console.WriteLine(string.Join(" ", input));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
