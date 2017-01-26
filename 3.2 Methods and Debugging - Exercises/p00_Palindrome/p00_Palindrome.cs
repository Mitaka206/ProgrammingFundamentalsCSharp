using System;

namespace p00_Palindrome
{
    class p00_Palindrome
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int rightIndex = word.Length - 1;
            int leftIndex = 0;

            bool isPalindrome = true;// if method, is not this line

            while (rightIndex >= leftIndex)
            {
                if (word[rightIndex] != word[leftIndex])
                {

                    isPalindrome = false;//return falce;
                }
                rightIndex--;
                leftIndex++;
            }

            //return true;
            Console.WriteLine(isPalindrome);

        }
    }
}
