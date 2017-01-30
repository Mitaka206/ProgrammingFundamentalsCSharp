using System;
using System.Linq;

namespace p11_EqualSums
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            bool sumfound = false;

            for (int i = 0; i < input.Length; i++)
            {
                long leftSum = 0;
                long rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                for (int j = i + 1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    sumfound = true;
                    break;
                }
            }

            if (!sumfound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
