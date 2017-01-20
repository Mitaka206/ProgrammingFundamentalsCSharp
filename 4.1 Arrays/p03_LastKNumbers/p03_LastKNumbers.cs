using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_LastKNumbers
{
    class p03_LastKNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];

            array[0] = 1;

            // absolutely not understand
            for (int i = 1; i < array.Length; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    sum += array[j];
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
