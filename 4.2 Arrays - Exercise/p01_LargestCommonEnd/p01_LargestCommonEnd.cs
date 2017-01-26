using System;

namespace p01_LargestCommonEnd
{
    class p01_LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var firstText = Console.ReadLine().Split();
            var secondText = Console.ReadLine().Split();

            int[] minArray = new int[Math.Min(firstText.Length, secondText.Length)];

            int countLeft = 0;
            int countRight = 0;



            for (int i = 0; i < minArray.Length; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    countLeft++;
                }
            }

            Array.Reverse(firstText);
            Array.Reverse(secondText);

            for (int i = 0; i < minArray.Length; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    countRight++;
                }
            }

            Console.WriteLine(Math.Max(countLeft, countRight));
        }
    }
}
