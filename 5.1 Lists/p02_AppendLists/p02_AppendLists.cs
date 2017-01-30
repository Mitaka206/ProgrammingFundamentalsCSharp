using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_AppendLists
{
    class p02_AppendLists
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();



            for (int i = 0; i < input.Count; i++)
            {
                input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                input[i].Reverse();
                Console.WriteLine(input[i].Trim());
            }

        }
    }
}
