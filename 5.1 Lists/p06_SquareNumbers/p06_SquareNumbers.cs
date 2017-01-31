using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SquareNumbers
{
    class p06_SquareNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> output = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                var square = Math.Sqrt(input[i]);

                if (square == (int)square)
                {
                    output.Add(input[i]);
                }
            }
            output = output.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
