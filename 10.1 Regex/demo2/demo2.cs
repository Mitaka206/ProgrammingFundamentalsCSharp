using System;
using System.Text.RegularExpressions;

namespace demo2
{
    class demo2
    {
        static void Main(string[] args)
        {
            var text = "asdasd ds ad.d,d ,sd .da sd,. d?!";

            var regex = new Regex(@"\w+");

            var words = regex.Matches(text);
            

            Console.WriteLine(words[0]);
            Console.WriteLine();

            foreach (Match item in words)
            {
                Console.Write("{0} ", item);
                Console.Write(item);
            }
        }
    }
}
