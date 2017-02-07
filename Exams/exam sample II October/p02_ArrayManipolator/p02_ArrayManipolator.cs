using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_ArrayManipolator
{
    class p02_ArrayManipolator
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commandLine = Console.ReadLine().Split().ToArray();

            while (!commandLine[0].Equals("end"))
            {
                switch (commandLine[0])
                {
                    case "exchange":

                        break;

                    case "max odd":
                        

                        break;

                    case "min even":
                        

                        break;
                        
                    case "first {count} even/odd":
                        

                        break;

                    case "last {count} even/odd ":
                        

                        break;
                }

                commandLine = Console.ReadLine().Split().ToArray();
            }

            //.......
        }
        
    }
}
