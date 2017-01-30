using System;
using System.Linq;

namespace p03_FoldAndSum
{
    class p03_FoldAndSum
    {
        static void Main(string[] args)
        {
            //string[] input = "1 2 3 4 5 6 7 8".Split();

            //int[] numbers = new int[input.Length];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    numbers[i] = int.Parse(input[i]);
            //}

            //int k = input.Length / 4;

            ////int[] arr1 = new int[k];
            ////int[] arr2 = new int[k];

            ////for (int i = 0; i < k; i++)
            ////{
            ////    arr1[i] = numbers[i];
            ////}

            ////for (int j = k - 1; j > 0; j--)
            ////{
            ////    arr2[j] = numbers[j-1];
            ////}
            //Console.WriteLine(string.Join(" ", arr1));
            //Console.WriteLine(string.Join(" ", arr2));

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;
            
            int[] leftNums = arr.Take(k).Reverse().ToArray();
            int[] rightNums = arr.Reverse().Take(k).ToArray();
            int[] row1 = leftNums.Concat(rightNums).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();               

            for (int i = 0; i < row1.Length; i++)
            {
                row1[i] += row2[i];
            }

            Console.Write(string.Join(" ", row1));
        }
    }
}
