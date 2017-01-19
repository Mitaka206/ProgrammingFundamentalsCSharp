using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_BooleanVariable
{
    class p03_BooleanVariable
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();

            bool isTrue = Convert.ToBoolean(boolean);

            if (isTrue == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }   
        }
    }
}
