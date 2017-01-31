using System;
using System.Linq;

namespace p03_SumAdjacentEqualNumbers
{
    class p03_SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int j = 0; j < input.Count; j++)
            {
                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i - 1] == input[i])
                    {
                        input[i - 1] += input[i];
                        input.Remove(input[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
