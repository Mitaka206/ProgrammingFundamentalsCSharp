using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace p04_CubicsMessages
{
    class p04_CubicsMessages
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            
            while (line != "Over!")
            {
                var count = int.Parse(Console.ReadLine());
                         //always START with digit; NEXT {massage}; always FINAL with only A-z
                var regex = new Regex($@"(^\d+)([A-Za-z]{{{count}}})([^A-Za-z]*$)");// ecape problem {{{}}}

                var match = regex.Match(line);

                if (match.Success)//ако имаме валиден вход/ ако match-а е успешен
                {
                    var left = match.Groups[1].Value;
                    var massage = match.Groups[2].Value;
                    var right = match.Groups[3].Value;// test

                    var indexes = string.Concat(left, right)
                        .Where(char.IsDigit)// get charDigits for any index
                        .Select(s => s - '0');// makes int all chars

                    var result = new StringBuilder();

                    foreach (var item in indexes)
                    {
                        if (item < 0 || item >= massage.Length)
                        {
                            result.Append(' ');
                        }
                        else
                        {
                            result.Append(massage[item]);
                        }
                    }

                    Console.WriteLine($"{massage} == {result}"); 
                }

                line = Console.ReadLine();
            }
        }
    }
}
