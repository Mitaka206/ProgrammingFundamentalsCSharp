using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p00_Demo
{
    class p00_Demo
    {
        static void Main(string[] args)
        {
            var text = "asd df 322 3f32 ffdsf rfwrf3444");
            
            var regex = new Regex(@"[a-z]+");

            var digit = regex.Split(text);
            
            Console.WriteLine(string.Join(" ", digit));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(digit[1]);
            Console.WriteLine();
            Console.WriteLine();

            //-------or

            regex = new Regex(@"\d+");

            var digit2 = regex.Matches(text);

            foreach (Match item in digit2)
            {
                Console.Write("{0} ", item);
            }

            //---------or get count
            Console.WriteLine();
            Console.WriteLine(digit2.Count);

        }
    }
}
