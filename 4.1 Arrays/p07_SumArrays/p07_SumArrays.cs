using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_SumArrays
{
    class p07_SumArrays
    {
        static void Main(string[] args)
        {
            string[] firstNumbers = "1 2 3 4 5".Split();//Console.ReadLine().Split();
            string[] secondNumbers = "1 2 ".Split(); //Console.ReadLine().Split();

            // 1 2 3 4 5
            // 5 4 3 _ _

            //var maxLength = Math.Max(firstNumbers.Length, secondNumbers.Length);

            //int[] first = new int[maxLength];
            //string[] second = new string[maxLength];//5

            //for (int i = 0; i < maxLength; i++)
            //{
            //    second[i] = secondNumbers[i];
            //}

            //int[] sum = new int[firstNumbers.Length];

            //for (int i = 0; i < firstNumbers.Length; i++)
            //{
            //    sum[i] = first[i] + int.Parse(second[i]);
            //}
            //Console.WriteLine(string.Join(", ", sum));

        }
    }
}
