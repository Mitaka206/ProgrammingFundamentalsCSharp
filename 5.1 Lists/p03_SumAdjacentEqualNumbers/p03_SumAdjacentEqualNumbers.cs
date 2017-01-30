using System;
using System.Linq;

namespace p03_SumAdjacentEqualNumbers
{
    class p03_SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();
            
            int sum = 0;

            while (sum < input.Count - 1)
            {
                if (input[sum] == input[sum + 1])
                {
                    input[sum] += input[sum + 1];

                    input.RemoveAt(sum + 1);

                    sum--;

                    if (sum < 0)
                    {
                        sum = 0;
                    }
                }
                else
                {
                    sum++;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
