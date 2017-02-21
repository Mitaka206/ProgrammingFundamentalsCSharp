using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_Ladybugs
{
    class p02_Ladybugs
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());

            var field = new string[sizeField];

            var bug = Console.ReadLine().Split().Select(int.Parse).ToList();// index 

            var line = Console.ReadLine();

            while (line != "end")
            {
                var command = line.Split().ToArray();

                var fromPosition = int.Parse(command[0]);
                var toPosition = int.Parse(command[2]);
                var lefOrRight = command[1];


                for (int i = 0; i < field.Length; i++)
                {
                    if (fromPosition == bug.IndexOf(i))
                    {
                        // NOOOOO non no onn o
                    }
                }


                line = Console.ReadLine();
            }
            
            
        }
    }
}
