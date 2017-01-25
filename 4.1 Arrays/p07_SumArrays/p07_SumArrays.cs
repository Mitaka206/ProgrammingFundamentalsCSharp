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
            string[] firstNumbers = Console.ReadLine().Split();
            string[] secondNumbers = Console.ReadLine().Split();

            // 1 2 3 4 5
            // 5 4 3 5 4 

            int[] first = new int[firstNumbers.Length];
            int[] second = new int[secondNumbers.Length];



            int[] sum = new int[firstNumbers.Length];

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                first[i] = int.Parse(firstNumbers[i]);
                second[i] = int.Parse(secondNumbers[i]);

                sum[i] = first[i] + second[i];
            }
            Console.WriteLine(string.Join(", ", sum));

        }
    }
}
