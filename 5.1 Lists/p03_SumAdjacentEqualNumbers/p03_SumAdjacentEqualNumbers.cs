using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_SumAdjacentEqualNumbers
{
    class p03_SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            List<int> sumList = new List<int>();

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i-1])
                {
                    sum = input[i] + input[i - 1];
                    input[i] = sum;
                }
                sumList.Add(sum);
            }
            Console.WriteLine(string.Join(" ", sumList));
        }
    }
}
