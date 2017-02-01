using System;

namespace p00_Palindrome
{
    class p00_Palindrome
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            
            Console.WriteLine(IsPalindrome(word));
        }

        private static bool IsPalindrome(string word)
        {
            int rightIndex = word.Length - 1;
            int leftIndex = 0;

            bool isPalindrome = true;

            while (rightIndex >= leftIndex)
            {
                if (word[rightIndex] != word[leftIndex])
                {
                    isPalindrome = false;
                }
                rightIndex--;
                leftIndex++;
            }

            return isPalindrome;
        }
    }
}
