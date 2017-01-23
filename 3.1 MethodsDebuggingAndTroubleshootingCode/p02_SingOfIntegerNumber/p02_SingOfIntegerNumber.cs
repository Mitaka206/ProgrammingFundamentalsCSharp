using System;

namespace p02_SingOfIntegerNumber
{
    class p02_SingOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SingNum(number);
        }

        public static void SingNum(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
