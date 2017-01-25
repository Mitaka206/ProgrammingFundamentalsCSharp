using System;

namespace p02_MaxMethod
{
    class p02_MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxOfNums(firstNum, secondNum, thirdNum));
        }

        public static int MaxOfNums(int firstNum, int secondNum, int thirdNum)
        {
            int maxOfTwo = Math.Max(firstNum, secondNum);

            int maxNum = Math.Max(maxOfTwo, thirdNum);
            return maxNum;
        }
    }
}
