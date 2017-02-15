using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p00_Demo
{
    class p00_Demo
    {
        static void Main(string[] args)
        {
            var text = "asd fsdf 322 3f32 ffdsf rfwrf3444";

            var pattern = @"[A-z]\s";//?????????????

            var regex = new Regex(pattern);

            var digit = regex.Split(text)
                .ToArray();


            Console.WriteLine(string.Join(" ", digit));     
        }
    }
}
