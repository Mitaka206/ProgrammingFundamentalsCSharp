using System;
namespace p08_MultiplyEvensByOdds
{
    class p08_MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(DigitOfNum(num));
        }

        private static int DigitOfNum(int num)
        {
            return Math.Abs(EvenSumOfDigits(num) * OddSumOfDigits(num));
        }

        private static int EvenSumOfDigits(int num)
        {
           return GetDigits(num, 0);
        }

        private static int OddSumOfDigits(int num)
        {
            return GetDigits(num, 1);
        }

        public static int GetDigits(int num, int reminder)
        {
            var result = 0;

            foreach (var symbol in num.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == reminder)
                {
                    result += digit;
                }
            }

            return result;
        }
    }
}
