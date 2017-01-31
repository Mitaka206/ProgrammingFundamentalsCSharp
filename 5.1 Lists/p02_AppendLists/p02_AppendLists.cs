using System;
using System.Linq;

namespace p02_AppendLists
{
    class p02_AppendLists
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            
            for (int i = 0; i < input.Count; i++)
            {
                string[] int1 = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.Write(string.Join(" ", int1));
                Console.Write(" ");
            }
        }
    }
}
