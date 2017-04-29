using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            var broadcast = new List<string>();
            var messeges = new List<string>();

            var input = Console.ReadLine();
            
            var pattern = @"^(\d+)\s+<->\s+([A-Za-z0-9]+)$";//3423423423
            var messegePattern = @"^(\D+)\s+<->\s+([A-Za-z0-9]+)$";

            var matchMessege = Regex.Match(input, messegePattern);
            var matchRegex = Regex.Match(input, pattern);//312312312
            
            var recipient = matchMessege.Groups[1].Value;
            var message = matchMessege.Groups[2].Value;

            var recipien2 = matchRegex.Groups[1].Value;
            var message2 = matchRegex.Groups[2].Value;

            if (matchRegex.Success || matchMessege.Success)
            {
                
            }




            var isMessige = new List<string>();

            while (input != "Hornet is Green")
            {
                



                input = Console.ReadLine();
            }

        }
    }
}
