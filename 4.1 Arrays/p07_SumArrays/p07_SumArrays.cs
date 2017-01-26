using System;
using System.Linq;

namespace p07_SumArrays
{
    class p07_SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] maxArray = new int[Math.Max(arr1.Length, arr2.Length)];
            int sum = Math.Max(arr1.Length, arr2.Length);

            for (int i = 0; i <= maxArray.Length; i++)
            {
                sum = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                if (i >= maxArray.Length)
                {
                    break;
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine();
            //---------------------------------------------------------------------------------------------------------------------------

            //string[] first = Console.ReadLine().Split();
            //string[] second = Console.ReadLine().Split();

            //int[] num = new int[first.Length];
            //int[] nums = new int[second.Length];

            //int max = Math.Max(first.Length, second.Length);

            //int[] sums = new int[max];

            //for (int i = 0; i < first.Length; i++)
            //{
            //    num[i] = int.Parse(first[i]);
            //}

            //for (int i = 0; i < second.Length; i++)
            //{
            //    nums[i] = int.Parse(second[i]);
            //}

            //for (int i = 0; i < max; i++)
            //{
            //    sums[i] = num[i % num.Length] + nums[i % nums.Length];
            //}

            //Console.WriteLine(string.Join(" ", sum));

            //---------------------------------------------------------------------------------------------------------------------------
        }
    }
}
