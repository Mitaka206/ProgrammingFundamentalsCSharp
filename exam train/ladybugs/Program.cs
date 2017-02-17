using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];
            var command = Console.ReadLine();
            while (command == "end")
            {
                var commandArr = command.Split().ToArray();
                int ladybugIndex = int.Parse(commandArr[0]);
                string direction = commandArr[1];
                int flyLen = int.Parse(commandArr[2]); ;
                

                command = Console.ReadLine();
            }
        }
    }
}
