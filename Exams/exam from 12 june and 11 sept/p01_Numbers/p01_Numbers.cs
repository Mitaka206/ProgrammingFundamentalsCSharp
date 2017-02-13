using System;
using System.Linq;

namespace p01_Numbers
{
    class p01_Numbers
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double averageNum = inputNumbers.Average();

            var output = inputNumbers.Where(x => x > averageNum).ToList();

            bool isBig = false;
            
            if (output.Count() > 0)
            {
                isBig = true;
                Console.WriteLine(string.Join(" ", output.OrderByDescending(x => x).Take(5)));
            }
            if (!isBig)
            {
                Console.WriteLine("No");
            }
        }
    }
}
