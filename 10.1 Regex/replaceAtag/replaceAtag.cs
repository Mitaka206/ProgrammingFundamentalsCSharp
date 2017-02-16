using System;
using System.Text.RegularExpressions;

namespace replaceAtag
{
    class replaceAtag
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"<a.*href=""(.*)"">(.*?)<\/a>");

            var result = regex.Replace(input, @"<ul> <li> <a href=""http://softuni.bg"">SoftUni</a></ li > </ ul >");

            Console.WriteLine(result);
        }
    }
}
