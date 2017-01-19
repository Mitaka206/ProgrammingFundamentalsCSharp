using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class p08_VowelOrDigits
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        char vowel = Convert.ToChar(input);
        

        bool isVowel = (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u');

        bool isDigit = (vowel <= 9 && vowel >= 0);

        if (isVowel)
        {
            Console.WriteLine("vowel");
        }
        else if (isDigit)
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
