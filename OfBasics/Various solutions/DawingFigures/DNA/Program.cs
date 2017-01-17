using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int rols = int.Parse(Console.ReadLine());
            

            int point = 3;
            int dna = 1;
            
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(new string('.', point) + new char(a, dna) + new string('.', point));
                point--;
                dna+=2;
                
            }
           
        }
    }
}
