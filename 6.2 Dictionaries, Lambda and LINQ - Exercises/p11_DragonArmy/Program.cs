using System;
using System.Collections.Generic;
using System.Linq;

namespace p11_DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                              
                var armyInfo = input.Split();//{type} {name} {damage} {health} {armor}. 

                string type = armyInfo[0];
                string name = armyInfo[1];
                int damage = int.Parse(armyInfo[2]);
                int health = int.Parse(armyInfo[3]);
                int armor = int.Parse(armyInfo[4]);





                //---- to do ------
            }
        }
    }
}
