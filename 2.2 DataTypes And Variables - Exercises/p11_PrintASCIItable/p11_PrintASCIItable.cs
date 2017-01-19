using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_PrintASCIItable
{
    class p11_PrintASCIItable
    {
        static void Main(string[] args)
        {
            int fromPositon = int.Parse(Console.ReadLine());
            int toPosition = int.Parse(Console.ReadLine());

            char from = (char)(fromPositon);

            for (char i = from; i <= toPosition; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
