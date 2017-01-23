using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p00_Demo
{
    class p00_demo
    {
        
        static void Main(string[] args)
        {
            
            RepeadString("* ", 5);
            RepeadString("| ", 6);
            RepeadString("* ", 5);
            Console.WriteLine();
            Console.WriteLine();

            PrintTriangle(5);

            Print(false);
        }

        private static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                    
                }
                Console.WriteLine();
                for (int k = i - 2; k >= 1; k--)
                {
                    Console.Write($"{k} ");
                }
                
            }
            
        }

        private static void Print(bool header)
        {
            if (header)
            {
                Console.WriteLine("Top");
            }
            else
            {
                Console.WriteLine("bot");
            }
        }

        private static void RepeadString(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
