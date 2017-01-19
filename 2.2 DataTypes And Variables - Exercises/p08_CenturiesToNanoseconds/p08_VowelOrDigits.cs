using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class p08_VowelOrDigits
{
    public static void Main(string[] args)
    {
        char input = char.Parse(Console.ReadLine());
        
        
        bool isVowel = (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u');

        bool isDigit = (input >= '0' && input <= '9');

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
