using System;
using System.Linq;

namespace p10_PairsByDifference
{
    class p10_PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = 0; j < inputArr.Length; j++)
                {
                    if (inputArr[i] - inputArr[j] == n)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
