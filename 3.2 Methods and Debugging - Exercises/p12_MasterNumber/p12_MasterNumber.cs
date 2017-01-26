using System;

namespace p12_MasterNumber
{
    class p12_MasterNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i < n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPalindrome(int number)
        {
            string word = number.ToString();

            int rightIndex = word.Length - 1;
            int leftIndex = 0;

            while (rightIndex >= leftIndex)
            {
                if (word[rightIndex] != word[leftIndex])
                {
                    return false;
                }
                rightIndex--;
                leftIndex++;
            }

            return true;
        }

        public static bool SumOfDigits(int number)
        {
            string word = number.ToString();

            var sum = 0;

            foreach (var nums in word)
            {
                var digit = nums - '0';
                sum += digit;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ContainsOneEvenDigit(int number)
        {
            string word = number.ToString();


            foreach (var nums in word)
            {
                var digit = nums - '0';
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;

        }
    }
}