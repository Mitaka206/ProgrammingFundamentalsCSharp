using System;

namespace p02_RotateAndSum
{
    class p02_RotateAndSum
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());

            int[] revArr = new int[inputArray.Length];
            
            for (int i = 0; i < revArr.Length; i++)
            {
                revArr[i] = int.Parse(inputArray[i]);
            }

            int[] sum = new int[inputArray.Length];

            for (int i = 0; i < count; i++)
            {
                int lastnum = revArr[revArr.Length-1];

                for (int j = inputArray.Length - 1; j > 0; j--)
                {
                    revArr[j] = revArr[j-1];
                }

                revArr[0] = lastnum;

                for (int k = 0; k < revArr.Length; k++)
                {
                    sum[k] += revArr[k];
                }
               // Console.WriteLine(string.Join(" ", revArr));
            }
          
            Console.WriteLine(string.Join(" ", sum));

        }

    }
}

